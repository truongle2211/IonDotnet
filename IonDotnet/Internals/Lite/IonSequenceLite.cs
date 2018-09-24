using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace IonDotnet.Internals.Lite
{
    internal abstract class IonSequenceLite : IonContainerLite, IIonSequence
    {
        private int _childCount;
        private IonValueLite[] _children;
        
        protected IonSequenceLite(ContainerlessContext containerlessContext, bool isNull) : base(containerlessContext, isNull)
        {
        }

        protected IonSequenceLite(IonContainerLite existing, IContext context, bool isStruct) : base(existing, context, isStruct)
        {
        }

        private IonValueLite Get_child(int index)
        {
            if (index < 0 || index >= _childCount)
            {
                throw new ArgumentOutOfRangeException();
            }

            return _children[index];
        }


        public int IndexOf(IIonValue item)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(int index, IIonValue item)
        {
            if (index < 0 || index > _childCount)
            {
                throw new ArgumentOutOfRangeException();
            }

            CheckLocked();
            // need more
            throw new NotImplementedException();
        }


        public virtual void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public virtual IIonValue this[int index]
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public IIonValue Get(int index)
        {
            ValidateThisNotNull();
            return Get_child(index);
        }

        public new bool Add(IIonValue child)
        {
            base.Add(child);
            return true;
        }

        public virtual IValueFactory Add()
        {
            throw new System.NotImplementedException();
        }

        public IValueFactory Add(int index)
        {
            throw new System.NotImplementedException();
        }

        public IIonValue Set(int index, IIonValue element)
        {
            throw new System.NotImplementedException();
        }

        public IIonValue Remove(int index)
        {
            CheckLocked();

            if (index < 0 || index >= _childCount)
            {
                throw new ArgumentOutOfRangeException();
            }

            IonValueLite v = _children[index];
//            var newArray = new List<IonValueLite>();
//            for (int i = 0; i < index; i++)
//            {
//                newArray.Add(_children[i]);
//            }
//
//            for (int i = index+1; i < _childCount; i++)
//            {
//                newArray.Add(_children[i]);
//            }
//            IonValueLite[] before = _children[0:index];
            

            return v;
            
            
            throw new System.NotImplementedException();
        }

        public bool Remove(object o)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveAll(ICollection c)
        {
            throw new System.NotImplementedException();
        }

        public bool RetainAll(ICollection c)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(object o)
        {
            throw new System.NotImplementedException();
        }

        public bool ContainsAll(ICollection c)
        {
            throw new System.NotImplementedException();
        }

        public int IndexOf(object o)
        {
            throw new System.NotImplementedException();
        }

        public int LastIndexOf(object o)
        {
            throw new System.NotImplementedException();
        }

        public bool AddAll(ICollection<IIonValue> c)
        {
            throw new System.NotImplementedException();
        }

        public bool AddAll(int index, ICollection<IIonValue> c)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<IIonValue> ListIterator(int index)
        {
            throw new System.NotImplementedException();
        }

        public List<IIonValue> SubList(int from, int to)
        {
            if (from < 0 || from > to || from >= _childCount || to < 0 || to >= _childCount)
            {
                throw new ArgumentOutOfRangeException();
            }

            var newArray = new List<IIonValue>();

            for (int i = from; i < to; i++)
            {
                newArray.Add(_children[i]);
            }

            return newArray;
        }

        public IIonValue[] ToArray()
        {
            IIonValue[] newArray = new IIonValue[_childCount];
            for (int i = 0; i < _childCount; i++)
            {
                newArray[i] = _children[i];
            }

            return newArray;
        }
    }
}
