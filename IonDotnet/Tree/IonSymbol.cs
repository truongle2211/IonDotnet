using IonDotnet.Internals;

namespace IonDotnet.Tree
{
    public sealed class IonSymbol : IonText
    {
        private int _sid;

        public IonSymbol(string text, int sid = SymbolToken.UnknownSid) : this(new SymbolToken(text, sid))
        {
        }

        public IonSymbol(SymbolToken symbolToken) : base(symbolToken.Text, symbolToken == default)
        {
            _sid = symbolToken.Sid;
        }

        private IonSymbol(bool isNull) : base(null, isNull)
        {
        }

        /// <summary>
        /// Returns a new null.symbol value.
        /// </summary>
        public static IonSymbol NewNull() => new IonSymbol(true);

        public override bool IsEquivalentTo(IonValue other)
        {
            if (!(other is IonSymbol oSymbol))
                return false;

            if (NullFlagOn())
                return oSymbol.IsNull;

            return !oSymbol.IsNull && oSymbol.StringVal == StringValue;
        }

        internal override void WriteBodyTo(IPrivateWriter writer)
        {
            if (NullFlagOn())
            {
                writer.WriteNull(IonType.Symbol);
                return;
            }

            writer.WriteSymbol(StringValue);
        }

        public override IonType Type => IonType.Symbol;

        public override string StringValue
        {
            get => base.StringValue;
            set
            {
                base.StringValue = value;
                _sid = SymbolToken.UnknownSid;
            }
        }

        public SymbolToken SymbolValue
        {
            get => new SymbolToken(StringVal, _sid);
            set
            {
                StringValue = value.Text;
                _sid = value.Sid;
            }
        }
    }
}
