namespace ExcelDataReader.Core.BinaryFormat
{
    /// <summary>
    /// Represents a constant integer number in range 0..65535
    /// </summary>
    internal class XlsBiffIntegerCell : XlsBiffBlankCell
    {
        internal XlsBiffIntegerCell(byte[] bytes, uint offset, ExcelBinaryReader reader)
            : base(bytes, offset, reader)
        {
        }

        /// <summary>
        /// Gets the cell value.
        /// </summary>
        public uint Value => ReadUInt16(0x6);
    }
}