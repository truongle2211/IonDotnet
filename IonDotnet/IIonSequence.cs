using System;
using System.Collections;
using System.Collections.Generic;

namespace IonDotnet
{
    public interface IIonSequence : IIonContainer, IList<IIonValue>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns> the element at the given index, not null</returns>
        /// <exception cref="NullValueException"> if the return value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException"> if the index is out of range</exception>
        IIonValue Get(int index);

        /// <summary>
        /// Append a child value to the end of this sequence
        /// If this sequence is null, then it becomes a singe element sequence
        /// </summary>
        /// <param name="child">is the value appended to the sequence</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">if <param name="child"></param> is null</exception>
        /// <exception cref="ContainedValueException">if <param name="child"></param>is already part of the sequence</exception>
        /// <exception cref="ArgumentException"> if <param name="child"></param>is a <see cref="IIonDatagram"/></exception>
        new bool Add(IIonValue child);
        
        /// <summary>
        /// Provides a factory that when invoked constructs a new value and add it to this sequence
        /// TODO: add more explanation and examples here
        /// </summary>
        /// <returns></returns>
        IValueFactory Add();

        /// <summary>
        /// Insert a child value at the specific position in the sequence
        /// If the sequence is null, then it becomes a single element sequence
        /// </summary>
        /// <param name="index"></param>
        /// <param name="child"> the element appended to the sequence</param>
        /// <exception cref="ArgumentNullException">if child is null</exception>
        /// <exception cref="ContainedValueException"> if child is already part of the sequence</exception>
        /// <exception cref="ArgumentException"> if <param name="child"></param>is a <see cref="IIonDatagram"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"> if the index is out of range</exception>
        void Add(int index, IIonValue child);

        /// <summary>
        ///  Provides a factory that when invoked constructs a new value and add it to this sequence
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IValueFactory Add(int index);

        IIonValue Set(int index, IIonValue element);
        IIonValue Remove(int index);
        bool Remove(object o);
        bool RemoveAll(ICollection c);
        bool RetainAll(ICollection c);
        bool Contains(object o);
        bool ContainsAll(ICollection c);
        int IndexOf(object o);
        int LastIndexOf(object o);
        bool AddAll(ICollection<IIonValue> c);
        bool AddAll(int index, ICollection<IIonValue> c);
        IEnumerator<IIonValue> ListIterator(int index);
        List<IIonValue> SubList(int from, int to);
        IIonValue[] ToArray();
        
    }
}
