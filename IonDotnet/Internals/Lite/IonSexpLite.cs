namespace IonDotnet.Internals.Lite
{
    internal sealed class IonSexpLite: IonSequenceLite, IIonSexp
    {
        public IonSexpLite(ContainerlessContext containerlessContext, bool isNull) : base(containerlessContext, isNull)
        {
        }

        public IonSexpLite(IonContainerLite existing, IContext context, bool isStruct) : base(existing, context, isStruct)
        {
        }

        protected override int GetHashCode(ISymbolTableProvider symbolTableProvider)
        {
            throw new System.NotImplementedException();
        }

        public override IonValueLite Clone(IContext parentContext)
        {
            throw new System.NotImplementedException();
        }

        protected override void WriteBodyTo(IIonWriter writer, ISymbolTableProvider symbolTableProvider)
        {
            throw new System.NotImplementedException();
        }

        public override IonType Type => IonType.Sexp;

        public override void Accept(IValueVisitor visitor)
        {
            throw new System.NotImplementedException();
        }

        public override int IndexOf(IIonValue item)
        {
            throw new System.NotImplementedException();
        }

        public override void Insert(int index, IIonValue item)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public override IIonValue this[int index]
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public override IValueFactory Add()
        {
            throw new System.NotImplementedException();
        }

        public IIonSexp Clone()
        {
            throw new System.NotImplementedException();
        }
    }
}