using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVIOContext
    {
        public AVClass* av_class;
        public sbyte* buffer;
        public int buffer_size;
        public sbyte* buf_ptr;
        public sbyte* buf_end;
        public void* opaque;
        public IntPtr read_packet; // Func<void*, byte*, int, int>
        public IntPtr write_packet; // Func<void*, byte*, int, int>
        public IntPtr seek; // Func<void*, long, int, long>
        public long pos;
        public int must_flush;
        public int eof_reached;
        public int write_flag;
        public int max_packet_size;
        public int checksum;
        public sbyte* checksum_ptr;
        public IntPtr update_checksum; // Func<int, byte*, int, int>
        public int error;
        public IntPtr read_pause; // Func<void*, int, int>
        public IntPtr read_seek; // Func<void*, int, long, int, long>
        public int seekable;
        public long maxsize;
        public int direct;
        public long bytes_read;
        public int seek_count;
        public int writeout_count;
        public int orig_buffer_size;
    }
}