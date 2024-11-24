using System.IO;

namespace UnityEditor.U2D.Aseprite
{
    /// <summary>
    /// Parsed representation of an Aseprite CellExtra chunk.
    /// Not supported yet.
    /// </summary>
    internal class CellExtra : BaseChunk
    {
        /// <inheritdoc />
        public override ChunkTypes chunkType => ChunkTypes.CellExtra;
        internal CellExtra(uint chunkSize) : base(chunkSize) { }
        
        /// <summary>
        /// Read and store the chunk data.
        /// </summary>
        /// <param name="reader">The active binary reader of the file.</param>        
        protected override void InternalRead(BinaryReader reader) { }
    }
}
