using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koblius.NET.Parser
{
    public struct AttributeValue
    {
        public byte[]? Value { get; private set; } = null;
        public byte Length { get; private set; }

        public AttributeValue(AttributeLength attributeLength, byte[]? value = null)
        {
            Length = (byte)(attributeLength.Length - 2);
            Value = ValidateValue(value);
        }

        private byte[]? ValidateValue(byte[]? value)
        {
            return ChainValidation(value);
        }

        private byte[]? ChainValidation(byte[]? value)
        {
            return IsValueNotNullAndLengthIsNotZero(value);
        }

        private byte[]? IsValueNotNullAndLengthIsNotZero(byte[]? value)
        {
            if (value != null && Length != 0)
                return IsLengthEqualValueLength(value);

            return value;
        }

        private byte[]? IsLengthEqualValueLength(byte[]? value)
        {
            if (Length == value.Length)
                return value;

            throw new ArgumentException(nameof(value));
        }
    }
}
