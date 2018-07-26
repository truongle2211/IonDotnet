﻿using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using IonDotnet.Internals;
using IonDotnet.Internals.Binary;
using IonDotnet.Serialization;
using Newtonsoft.Json;

namespace IonDotnet.Bench
{
    // ReSharper disable once UnusedMember.Global
    public class SerializerGround : IRunable
    {
        public class SimplePoco
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Nickname { get; set; }
            public int Id { get; set; }
            public bool IsHandsome { get; set; }
        }

        [MemoryDiagnoser]
        public class Benchmark
        {
            public static List<SimplePoco> Data = GenerateArray();

            private static List<SimplePoco> GenerateArray()
            {
                var random = new Random();
                var l = new List<SimplePoco>();
                for (var i = 0; i < 2000; i++)
                {
                    l.Add(new SimplePoco
                    {
                        Name = $"Bob{i}",
                        Age = random.Next(0, int.MaxValue / 5),
                        Nickname = Guid.NewGuid().ToString(),
                        IsHandsome = true,
                        Id = random.Next(0, int.MaxValue / 3)
                    });
                }

                return l;
            }

            private readonly IonSerializer _serializer = new IonSerializer();

            [Benchmark]
            public void JsonDotnet()
            {
                JsonConvert.SerializeObject(Data);
            }

            [Benchmark]
            public void IonDotnet()
            {
                _serializer.Serialize(Data);
            }

            [Benchmark]
            public void IonDotnetManual()
            {
                //                _serializer.Serialize(Data);
                //                using (var stream = new MemoryStream())
                //                {
                using (var writer = new ManagedBinaryWriter(IonConstants.EmptySymbolTablesArray))
                {
                    writer.StepIn(IonType.List);
                    foreach (var poco in Data)
                    {
                        writer.StepIn(IonType.Struct);

                        writer.SetFieldName("Age");
                        writer.WriteInt(poco.Age);
                        writer.SetFieldName("Name");
                        writer.WriteString(poco.Name);
                        writer.SetFieldName("Nickname");
                        writer.WriteString(poco.Nickname);
                        writer.SetFieldName("IsHandsome");
                        writer.WriteBool(poco.IsHandsome);
                        writer.SetFieldName("Id");
                        writer.WriteInt(poco.Id);

                        writer.StepOut();
                    }

                    writer.StepOut();
                    //                        writer.Finish(stream);
                }
                //                }
            }
        }

        public void Run(ArraySegment<string> args)
        {
            BenchmarkRunner.Run<Benchmark>();


//            var bm = new Benchmark();
//            for (var i = 0; i < 100000; i++)
//            {
//                bm.IonDotnet();
//            }
        }
    }
}