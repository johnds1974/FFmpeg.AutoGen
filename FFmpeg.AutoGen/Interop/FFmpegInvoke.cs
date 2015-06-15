using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    // Func<AVFormatContext*, int, void*, uint, int>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int av_format_control_message(AVFormatContext* s, int type, void* data, uint data_size);
	
	// Func<AVFilterContext*, void*, int, int, int>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int avfilter_action_func(AVFilterContext* ctx, void* arg, int jobnr, int nb_jobs);
	
	// Func<AVFilterContext*, avfilter_action_func*, void*, int*, int, int>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public unsafe delegate int avfilter_execute_func(AVFilterContext* ctx, IntPtr func_func, void* arg, int* ret, int nb_jobs);

    public static unsafe class FFmpegInvoke
	{
		public const string POSTPROC_LIBRARY = "postproc-53";
		public const string SWSCALE_LIBRARY = "swscale-3";
		public const string AVFORMAT_LIBRARY = "avformat-56";
		public const string AVFILTER_LIBRARY = "avfilter-5";
		public const string SWRESAMPLE_LIBRARY = "swresample-1";
		public const string AVUTIL_LIBRARY = "avutil-54";
		public const string AVDEVICE_LIBRARY = "avdevice-56";
		public const string AVCODEC_LIBRARY = "avcodec-56";
		
		public const int FF_LAMBDA_SHIFT = 0x7;
		public const int FF_LAMBDA_SCALE = 0x1; // (1 << FF_LAMBDA_SHIFT)
		public const int FF_QP2LAMBDA = 0x76;
		public const int FF_LAMBDA_MAX = 0x7fff; // ((256 * 128) - 1)
		public const int FF_QUALITY_SCALE = 0x0; // FF_LAMBDA_SCALE
		public const ulong AV_NOPTS_VALUE = 0x8000000000000000L; // ((UINT64_C (9223372036854775808L)).value)
		public const int AV_TIME_BASE = 0xf4240;
		public const int AV_GCC_VERSION_AT_LEAST = 0x0;
		public const int av_always_inline = 0x1; // inline
		public const int av_extern_inline = 0x1; // inline
		public const int AV_NOWARN_DEPRECATED = 0x0; // code
		public const int av_uninit = 0x0; // x
		public const int av_builtin_constant_p = 0x0;
		public const int AV_TOSTRING = 0x0; // s
		public const int AV_VERSION_INT = 0x0; // (((a << 16) | (b << 8)) | c)
		public const int LIBAVUTIL_VERSION_MAJOR = 0x36;
		public const int LIBAVUTIL_VERSION_MINOR = 0xf;
		public const int LIBAVUTIL_VERSION_MICRO = 0x64;
		public const int LIBAVUTIL_BUILD = 0x0; // LIBAVUTIL_VERSION_INT
		public const int FF_API_OLD_AVOPTIONS = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_PIX_FMT = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_CONTEXT_SIZE = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_PIX_FMT_DESC = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_AV_REVERSE = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_AUDIOCONVERT = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_CPU_FLAG_MMX2 = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_LLS_PRIVATE = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_AVFRAME_LAVC = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_VDPAU = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_GET_CHANNEL_LAYOUT_COMPAT = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_XVMC = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int FF_API_OPT_TYPE_METADATA = 0x1; // (LIBAVUTIL_VERSION_MAJOR < 55)
		public const int AV_HAVE_BIGENDIAN = 0x0;
		public const int AV_HAVE_FAST_UNALIGNED = 0x1;
		public const int AV_HAVE_INCOMPATIBLE_LIBAV_ABI = 0x0;
		public const int AV_NE = 0x0; // le
		public const int RSHIFT = -0x1; // (a > 0) and ((a + ((1 << b) >> 1)) >> b) or (((a + ((1 << b) >> 1)) - 1) >> b)
		public const int FFABS = 0x0; // (a >= 0) and a or (-a)
		public const int FFSIGN = -0x1; // (a > 0) and 1 or (-1)
		public const int FFMAX = 0x0; // (a > b) and a or b
		public const int FFMIN = 0x0; // (a > b) and b or a
		public const int FFALIGN = 0x0; // (((x + a) - 1) & (~(a - 1)))
		public const int av_ceil_log2 = 0x0; // av_ceil_log2_c
		public const int av_clip = 0x0; // av_clip_c
		public const int av_clip64 = 0x0; // av_clip64_c
		public const int av_clip_uint8 = 0x0; // av_clip_uint8_c
		public const int av_clip_int8 = 0x0; // av_clip_int8_c
		public const int av_clip_uint16 = 0x0; // av_clip_uint16_c
		public const int av_clip_int16 = 0x0; // av_clip_int16_c
		public const int av_clipl_int32 = 0x0; // av_clipl_int32_c
		public const int av_clip_uintp2 = 0x0; // av_clip_uintp2_c
		public const int av_sat_add32 = 0x0; // av_sat_add32_c
		public const int av_sat_dadd32 = 0x0; // av_sat_dadd32_c
		public const int av_clipf = 0x0; // av_clipf_c
		public const int av_clipd = 0x0; // av_clipd_c
		public const int av_popcount = 0x0; // av_popcount_c
		public const int av_popcount64 = 0x0; // av_popcount64_c
		public const int MKTAG = 0x0; // (((a | (b << 8)) | (c << 16)) | (d << 24))
		public const int MKBETAG = 0x0; // (((d | (c << 8)) | (b << 16)) | (a << 24))
		public const int AVERROR = 0x0; // (-e)
		public const int AVUNERROR = 0x0; // (-e)
		public const int AVERROR_EXPERIMENTAL = -0x2bb2afa8; // (-733130664)
		public const int AVERROR_INPUT_CHANGED = -0x636e6701; // (-1668179713)
		public const int AVERROR_OUTPUT_CHANGED = -0x636e6702; // (-1668179714)
		public const int AV_ERROR_MAX_STRING_SIZE = 0x40;
		public const int DECLARE_ALIGNED = 0x0; // (t + v)
		public const float M_LOG2_10 = 3.321928f; // 3.321928094887362
		public const float M_PHI = 1.618034f; // 1.618033988749895
		public const int AV_IS_INPUT_DEVICE = 0x0; // (((category == AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT) or (category == AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT)) or (category == AV_CLASS_CATEGORY_DEVICE_INPUT))
		public const int AV_IS_OUTPUT_DEVICE = 0x0; // (((category == AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT) or (category == AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT)) or (category == AV_CLASS_CATEGORY_DEVICE_OUTPUT))
		public const int AV_LOG_QUIET = -0x8; // (-8)
		public const int AV_LOG_PANIC = 0x0;
		public const int AV_LOG_FATAL = 0x8;
		public const int AV_LOG_ERROR = 0x10;
		public const int AV_LOG_WARNING = 0x18;
		public const int AV_LOG_INFO = 0x20;
		public const int AV_LOG_VERBOSE = 0x28;
		public const int AV_LOG_DEBUG = 0x30;
		public const int AV_LOG_MAX_OFFSET = 0x0; // (AV_LOG_DEBUG - AV_LOG_QUIET)
		public const int AV_LOG_C = 0x0; // (x << 8)
		public const int AV_LOG_SKIP_REPEATED = 0x1;
		public const int AV_LOG_PRINT_LEVEL = 0x2;
		public const int AVPALETTE_SIZE = 0x400;
		public const int AVPALETTE_COUNT = 0x100;
		public const int AV_PIX_FMT_XVMC = 0x10; // AV_PIX_FMT_XVMC_MPEG2_IDCT
		public const int AV_PIX_FMT_Y400A = 0x42; // AV_PIX_FMT_GRAY8A
		public const int AV_PIX_FMT_GBR24P = 0x52; // AV_PIX_FMT_GBRP
		public const int PixelFormat = 0x0; // AVPixelFormat
		public const int PIX_FMT_Y400A = 0x42; // AV_PIX_FMT_Y400A
		public const int PIX_FMT_GBR24P = 0x0; // AV_PIX_FMT_GBR24P
		public const int PIX_FMT_RGB32 = 0x0; // AV_PIX_FMT_RGB32
		public const int PIX_FMT_RGB32_1 = 0x0; // AV_PIX_FMT_RGB32_1
		public const int PIX_FMT_BGR32 = 0x0; // AV_PIX_FMT_BGR32
		public const int PIX_FMT_BGR32_1 = 0x0; // AV_PIX_FMT_BGR32_1
		public const int PIX_FMT_0RGB32 = 0x0; // AV_PIX_FMT_0RGB32
		public const int PIX_FMT_0BGR32 = 0x0; // AV_PIX_FMT_0BGR32
		public const int PIX_FMT_GRAY16 = 0x0; // AV_PIX_FMT_GRAY16
		public const int PIX_FMT_RGB48 = 0x0; // AV_PIX_FMT_RGB48
		public const int PIX_FMT_RGB565 = 0x0; // AV_PIX_FMT_RGB565
		public const int PIX_FMT_RGB555 = 0x0; // AV_PIX_FMT_RGB555
		public const int PIX_FMT_RGB444 = 0x0; // AV_PIX_FMT_RGB444
		public const int PIX_FMT_BGR48 = 0x0; // AV_PIX_FMT_BGR48
		public const int PIX_FMT_BGR565 = 0x0; // AV_PIX_FMT_BGR565
		public const int PIX_FMT_BGR555 = 0x0; // AV_PIX_FMT_BGR555
		public const int PIX_FMT_BGR444 = 0x0; // AV_PIX_FMT_BGR444
		public const int PIX_FMT_YUV420P9 = 0x0; // AV_PIX_FMT_YUV420P9
		public const int PIX_FMT_YUV422P9 = 0x0; // AV_PIX_FMT_YUV422P9
		public const int PIX_FMT_YUV444P9 = 0x0; // AV_PIX_FMT_YUV444P9
		public const int PIX_FMT_YUV420P10 = 0x0; // AV_PIX_FMT_YUV420P10
		public const int PIX_FMT_YUV422P10 = 0x0; // AV_PIX_FMT_YUV422P10
		public const int PIX_FMT_YUV444P10 = 0x0; // AV_PIX_FMT_YUV444P10
		public const int PIX_FMT_YUV420P12 = 0x0; // AV_PIX_FMT_YUV420P12
		public const int PIX_FMT_YUV422P12 = 0x0; // AV_PIX_FMT_YUV422P12
		public const int PIX_FMT_YUV444P12 = 0x0; // AV_PIX_FMT_YUV444P12
		public const int PIX_FMT_YUV420P14 = 0x0; // AV_PIX_FMT_YUV420P14
		public const int PIX_FMT_YUV422P14 = 0x0; // AV_PIX_FMT_YUV422P14
		public const int PIX_FMT_YUV444P14 = 0x0; // AV_PIX_FMT_YUV444P14
		public const int PIX_FMT_YUV420P16 = 0x0; // AV_PIX_FMT_YUV420P16
		public const int PIX_FMT_YUV422P16 = 0x0; // AV_PIX_FMT_YUV422P16
		public const int PIX_FMT_YUV444P16 = 0x0; // AV_PIX_FMT_YUV444P16
		public const int PIX_FMT_RGBA64 = 0x0; // AV_PIX_FMT_RGBA64
		public const int PIX_FMT_BGRA64 = 0x0; // AV_PIX_FMT_BGRA64
		public const int PIX_FMT_GBRP9 = 0x0; // AV_PIX_FMT_GBRP9
		public const int PIX_FMT_GBRP10 = 0x0; // AV_PIX_FMT_GBRP10
		public const int PIX_FMT_GBRP12 = 0x0; // AV_PIX_FMT_GBRP12
		public const int PIX_FMT_GBRP14 = 0x0; // AV_PIX_FMT_GBRP14
		public const int PIX_FMT_GBRP16 = 0x0; // AV_PIX_FMT_GBRP16
		public const int AVCOL_SPC_YCGCO = 0x8; // AVCOL_SPC_YCOCG
		public const int AV_BUFFER_FLAG_READONLY = 0x1; // (1 << 0)
		public const long AV_CPU_FLAG_FORCE = 0x80000000L; // 2147483648L
		public const int AV_CPU_FLAG_MMX = 0x1;
		public const int AV_CPU_FLAG_MMXEXT = 0x2;
		public const int AV_CPU_FLAG_MMX2 = 0x2;
		public const int AV_CPU_FLAG_3DNOW = 0x4;
		public const int AV_CPU_FLAG_SSE = 0x8;
		public const int AV_CPU_FLAG_SSE2 = 0x10;
		public const int AV_CPU_FLAG_SSE2SLOW = 0x40000000;
		public const int AV_CPU_FLAG_3DNOWEXT = 0x20;
		public const int AV_CPU_FLAG_SSE3 = 0x40;
		public const int AV_CPU_FLAG_SSE3SLOW = 0x20000000;
		public const int AV_CPU_FLAG_SSSE3 = 0x80;
		public const int AV_CPU_FLAG_ATOM = 0x10000000;
		public const int AV_CPU_FLAG_SSE4 = 0x100;
		public const int AV_CPU_FLAG_SSE42 = 0x200;
		public const int AV_CPU_FLAG_AVX = 0x4000;
		public const int AV_CPU_FLAG_XOP = 0x400;
		public const int AV_CPU_FLAG_FMA4 = 0x800;
		public const int AV_CPU_FLAG_CMOV = 0x1001000;
		public const int AV_CPU_FLAG_AVX2 = 0x8000;
		public const int AV_CPU_FLAG_FMA3 = 0x10000;
		public const int AV_CPU_FLAG_BMI1 = 0x20000;
		public const int AV_CPU_FLAG_BMI2 = 0x40000;
		public const int AV_CPU_FLAG_ALTIVEC = 0x1;
		public const int AV_CPU_FLAG_ARMV5TE = 0x1; // (1 << 0)
		public const int AV_CPU_FLAG_ARMV6 = 0x2; // (1 << 1)
		public const int AV_CPU_FLAG_ARMV6T2 = 0x4; // (1 << 2)
		public const int AV_CPU_FLAG_VFP = 0x8; // (1 << 3)
		public const int AV_CPU_FLAG_VFPV3 = 0x10; // (1 << 4)
		public const int AV_CPU_FLAG_NEON = 0x20; // (1 << 5)
		public const int AV_CPU_FLAG_ARMV8 = 0x40; // (1 << 6)
		public const int AV_CPU_FLAG_SETEND = 0x10000; // (1 << 16)
		public const int AV_CH_FRONT_LEFT = 0x1;
		public const int AV_CH_FRONT_RIGHT = 0x2;
		public const int AV_CH_FRONT_CENTER = 0x4;
		public const int AV_CH_LOW_FREQUENCY = 0x8;
		public const int AV_CH_BACK_LEFT = 0x10;
		public const int AV_CH_BACK_RIGHT = 0x20;
		public const int AV_CH_FRONT_LEFT_OF_CENTER = 0x40;
		public const int AV_CH_FRONT_RIGHT_OF_CENTER = 0x80;
		public const int AV_CH_BACK_CENTER = 0x100;
		public const int AV_CH_SIDE_LEFT = 0x200;
		public const int AV_CH_SIDE_RIGHT = 0x400;
		public const int AV_CH_TOP_CENTER = 0x800;
		public const int AV_CH_TOP_FRONT_LEFT = 0x1000;
		public const int AV_CH_TOP_FRONT_CENTER = 0x2000;
		public const int AV_CH_TOP_FRONT_RIGHT = 0x4000;
		public const int AV_CH_TOP_BACK_LEFT = 0x8000;
		public const int AV_CH_TOP_BACK_CENTER = 0x10000;
		public const int AV_CH_TOP_BACK_RIGHT = 0x20000;
		public const int AV_CH_STEREO_LEFT = 0x20000000;
		public const int AV_CH_STEREO_RIGHT = 0x40000000;
		public const long AV_CH_WIDE_LEFT = 0x80000000L; // 2147483648L
		public const long AV_CH_WIDE_RIGHT = 0x100000000L; // 4294967296L
		public const long AV_CH_SURROUND_DIRECT_LEFT = 0x200000000L; // 8589934592L
		public const long AV_CH_SURROUND_DIRECT_RIGHT = 0x400000000L; // 17179869184L
		public const long AV_CH_LOW_FREQUENCY_2 = 0x800000000L; // 34359738368L
		public const ulong AV_CH_LAYOUT_NATIVE = 0x8000000000000000L; // 9223372036854775808L
		public const int AV_CH_LAYOUT_MONO = 0x0; // AV_CH_FRONT_CENTER
		public const int AV_CH_LAYOUT_STEREO = 0x0; // (AV_CH_FRONT_LEFT | AV_CH_FRONT_RIGHT)
		public const int AV_CH_LAYOUT_2POINT1 = 0x0; // (AV_CH_LAYOUT_STEREO | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_2_1 = 0x0; // (AV_CH_LAYOUT_STEREO | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_SURROUND = 0x0; // (AV_CH_LAYOUT_STEREO | AV_CH_FRONT_CENTER)
		public const int AV_CH_LAYOUT_3POINT1 = 0x0; // (AV_CH_LAYOUT_SURROUND | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_4POINT0 = 0x0; // (AV_CH_LAYOUT_SURROUND | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_4POINT1 = 0x0; // (AV_CH_LAYOUT_4POINT0 | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_2_2 = 0x0; // ((AV_CH_LAYOUT_STEREO | AV_CH_SIDE_LEFT) | AV_CH_SIDE_RIGHT)
		public const int AV_CH_LAYOUT_QUAD = 0x0; // ((AV_CH_LAYOUT_STEREO | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_5POINT0 = 0x0; // ((AV_CH_LAYOUT_SURROUND | AV_CH_SIDE_LEFT) | AV_CH_SIDE_RIGHT)
		public const int AV_CH_LAYOUT_5POINT1 = 0x0; // (AV_CH_LAYOUT_5POINT0 | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_5POINT0_BACK = 0x0; // ((AV_CH_LAYOUT_SURROUND | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_5POINT1_BACK = 0x0; // (AV_CH_LAYOUT_5POINT0_BACK | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_6POINT0 = 0x0; // (AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT0_FRONT = 0x0; // ((AV_CH_LAYOUT_2_2 | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_HEXAGONAL = 0x0; // (AV_CH_LAYOUT_5POINT0_BACK | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT1 = 0x0; // (AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT1_BACK = 0x0; // (AV_CH_LAYOUT_5POINT1_BACK | AV_CH_BACK_CENTER)
		public const int AV_CH_LAYOUT_6POINT1_FRONT = 0x0; // (AV_CH_LAYOUT_6POINT0_FRONT | AV_CH_LOW_FREQUENCY)
		public const int AV_CH_LAYOUT_7POINT0 = 0x0; // ((AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_7POINT0_FRONT = 0x0; // ((AV_CH_LAYOUT_5POINT0 | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_7POINT1 = 0x0; // ((AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_LEFT) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_7POINT1_WIDE = 0x0; // ((AV_CH_LAYOUT_5POINT1 | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_7POINT1_WIDE_BACK = 0x0; // ((AV_CH_LAYOUT_5POINT1_BACK | AV_CH_FRONT_LEFT_OF_CENTER) | AV_CH_FRONT_RIGHT_OF_CENTER)
		public const int AV_CH_LAYOUT_OCTAGONAL = 0x0; // (((AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT) | AV_CH_BACK_CENTER) | AV_CH_BACK_RIGHT)
		public const int AV_CH_LAYOUT_STEREO_DOWNMIX = 0x0; // (AV_CH_STEREO_LEFT | AV_CH_STEREO_RIGHT)
		public const int AV_DICT_MATCH_CASE = 0x1;
		public const int AV_DICT_IGNORE_SUFFIX = 0x2;
		public const int AV_DICT_DONT_STRDUP_KEY = 0x4;
		public const int AV_DICT_DONT_STRDUP_VAL = 0x8;
		public const int AV_DICT_DONT_OVERWRITE = 0x10;
		public const int AV_DICT_APPEND = 0x20;
		public const int AV_NUM_DATA_POINTERS = 0x8;
		public const int AV_FRAME_FLAG_CORRUPT = 0x1; // (1 << 0)
		public const int FF_DECODE_ERROR_INVALID_BITSTREAM = 0x1;
		public const int FF_DECODE_ERROR_MISSING_REFERENCE = 0x2;
		public const int LIBAVCODEC_VERSION_MAJOR = 0x38;
		public const int LIBAVCODEC_VERSION_MINOR = 0xd;
		public const int LIBAVCODEC_VERSION_MICRO = 0x64;
		public const int LIBAVCODEC_BUILD = 0x0; // LIBAVCODEC_VERSION_INT
		public const int FF_API_REQUEST_CHANNELS = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_OLD_DECODE_AUDIO = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_OLD_ENCODE_AUDIO = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_OLD_ENCODE_VIDEO = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_CODEC_ID = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_AUDIO_CONVERT = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_AVCODEC_RESAMPLE = 0x0; // FF_API_AUDIO_CONVERT
		public const int FF_API_DEINTERLACE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_DESTRUCT_PACKET = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_GET_BUFFER = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_MISSING_SAMPLE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_LOWRES = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_CAP_VDPAU = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_BUFS_VDPAU = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_VOXWARE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_SET_DIMENSIONS = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_DEBUG_MV = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_AC_VLC = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_OLD_MSMPEG4 = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_ASPECT_EXTENDED = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_THREAD_OPAQUE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_CODEC_PKT = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_ARCH_ALPHA = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_ERROR_RATE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_QSCALE_TYPE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_MB_TYPE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_MAX_BFRAMES = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_NEG_LINESIZES = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_EMU_EDGE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_ARCH_SH4 = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_ARCH_SPARC = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_UNUSED_MEMBERS = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_IDCT_XVIDMMX = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_INPUT_PRESERVED = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_NORMALIZE_AQP = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_GMC = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_MV0 = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_CODEC_NAME = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_AFD = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_VISMV = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_DV_FRAME_PROFILE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 57)
		public const int FF_API_AUDIOENC_DELAY = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 58)
		public const int FF_API_AVCTX_TIMEBASE = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 59)
		public const int FF_API_MPV_OPT = 0x1; // (LIBAVCODEC_VERSION_MAJOR < 59)
		public const int AV_CODEC_ID_H265 = 0x48323635; // AV_CODEC_ID_HEVC
		public const int AV_CODEC_PROP_INTRA_ONLY = 0x1; // (1 << 0)
		public const int AV_CODEC_PROP_LOSSY = 0x2; // (1 << 1)
		public const int AV_CODEC_PROP_LOSSLESS = 0x4; // (1 << 2)
		public const int AV_CODEC_PROP_REORDER = 0x8; // (1 << 3)
		public const int AV_CODEC_PROP_BITMAP_SUB = 0x10000; // (1 << 16)
		public const int AV_CODEC_PROP_TEXT_SUB = 0x20000; // (1 << 17)
		public const int FF_INPUT_BUFFER_PADDING_SIZE = 0x20;
		public const int FF_MIN_BUFFER_SIZE = 0x4000;
		public const int FF_MAX_B_FRAMES = 0x10;
		public const int CODEC_FLAG_UNALIGNED = 0x1;
		public const int CODEC_FLAG_QSCALE = 0x2;
		public const int CODEC_FLAG_4MV = 0x4;
		public const int CODEC_FLAG_OUTPUT_CORRUPT = 0x8;
		public const int CODEC_FLAG_QPEL = 0x10;
		public const int CODEC_FLAG_GMC = 0x20;
		public const int CODEC_FLAG_MV0 = 0x40;
		public const int CODEC_FLAG_INPUT_PRESERVED = 0x100;
		public const int CODEC_FLAG_PASS1 = 0x200;
		public const int CODEC_FLAG_PASS2 = 0x400;
		public const int CODEC_FLAG_GRAY = 0x2000;
		public const int CODEC_FLAG_EMU_EDGE = 0x4000;
		public const int CODEC_FLAG_PSNR = 0x8000;
		public const int CODEC_FLAG_TRUNCATED = 0x10000;
		public const int CODEC_FLAG_NORMALIZE_AQP = 0x20000;
		public const int CODEC_FLAG_INTERLACED_DCT = 0x40000;
		public const int CODEC_FLAG_LOW_DELAY = 0x80000;
		public const int CODEC_FLAG_GLOBAL_HEADER = 0x400000;
		public const int CODEC_FLAG_BITEXACT = 0x800000;
		public const int CODEC_FLAG_AC_PRED = 0x1000000;
		public const int CODEC_FLAG_LOOP_FILTER = 0x800;
		public const int CODEC_FLAG_INTERLACED_ME = 0x20000000;
		public const long CODEC_FLAG_CLOSED_GOP = 0x80000000L; // 2147483648L
		public const int CODEC_FLAG2_FAST = 0x1;
		public const int CODEC_FLAG2_NO_OUTPUT = 0x4;
		public const int CODEC_FLAG2_LOCAL_HEADER = 0x8;
		public const int CODEC_FLAG2_DROP_FRAME_TIMECODE = 0x2000;
		public const int CODEC_FLAG2_IGNORE_CROP = 0x10000;
		public const int CODEC_FLAG2_CHUNKS = 0x8000;
		public const int CODEC_FLAG2_SHOW_ALL = 0x400000;
		public const int CODEC_FLAG2_EXPORT_MVS = 0x10000000;
		public const int CODEC_FLAG2_SKIP_MANUAL = 0x20000000;
		public const int CODEC_CAP_DRAW_HORIZ_BAND = 0x1;
		public const int CODEC_CAP_DR1 = 0x2;
		public const int CODEC_CAP_TRUNCATED = 0x8;
		public const int CODEC_CAP_HWACCEL = 0x10;
		public const int CODEC_CAP_DELAY = 0x20;
		public const int CODEC_CAP_SMALL_LAST_FRAME = 0x40;
		public const int CODEC_CAP_HWACCEL_VDPAU = 0x80;
		public const int CODEC_CAP_SUBFRAMES = 0x100;
		public const int CODEC_CAP_EXPERIMENTAL = 0x200;
		public const int CODEC_CAP_CHANNEL_CONF = 0x400;
		public const int CODEC_CAP_NEG_LINESIZES = 0x800;
		public const int CODEC_CAP_FRAME_THREADS = 0x1000;
		public const int CODEC_CAP_SLICE_THREADS = 0x2000;
		public const int CODEC_CAP_PARAM_CHANGE = 0x4000;
		public const int CODEC_CAP_AUTO_THREADS = 0x8000;
		public const int CODEC_CAP_VARIABLE_FRAME_SIZE = 0x10000;
		public const int CODEC_CAP_INTRA_ONLY = 0x40000000;
		public const long CODEC_CAP_LOSSLESS = 0x80000000L; // 2147483648L
		public const int MB_TYPE_INTRA4x4 = 0x1;
		public const int MB_TYPE_INTRA16x16 = 0x2;
		public const int MB_TYPE_INTRA_PCM = 0x4;
		public const int MB_TYPE_16x16 = 0x8;
		public const int MB_TYPE_16x8 = 0x10;
		public const int MB_TYPE_8x16 = 0x20;
		public const int MB_TYPE_8x8 = 0x40;
		public const int MB_TYPE_INTERLACED = 0x80;
		public const int MB_TYPE_DIRECT2 = 0x100;
		public const int MB_TYPE_ACPRED = 0x200;
		public const int MB_TYPE_GMC = 0x400;
		public const int MB_TYPE_SKIP = 0x800;
		public const int MB_TYPE_P0L0 = 0x1000;
		public const int MB_TYPE_P1L0 = 0x2000;
		public const int MB_TYPE_P0L1 = 0x4000;
		public const int MB_TYPE_P1L1 = 0x8000;
		public const int MB_TYPE_L0 = 0x0; // (MB_TYPE_P0L0 | MB_TYPE_P1L0)
		public const int MB_TYPE_L1 = 0x0; // (MB_TYPE_P0L1 | MB_TYPE_P1L1)
		public const int MB_TYPE_L0L1 = 0x0; // (MB_TYPE_L0 | MB_TYPE_L1)
		public const int MB_TYPE_QUANT = 0x10000;
		public const int MB_TYPE_CBP = 0x20000;
		public const int FF_QSCALE_TYPE_MPEG1 = 0x0;
		public const int FF_QSCALE_TYPE_MPEG2 = 0x1;
		public const int FF_QSCALE_TYPE_H264 = 0x2;
		public const int FF_QSCALE_TYPE_VP56 = 0x3;
		public const int FF_BUFFER_TYPE_INTERNAL = 0x1;
		public const int FF_BUFFER_TYPE_USER = 0x2;
		public const int FF_BUFFER_TYPE_SHARED = 0x4;
		public const int FF_BUFFER_TYPE_COPY = 0x8;
		public const int FF_BUFFER_HINTS_VALID = 0x1;
		public const int FF_BUFFER_HINTS_READABLE = 0x2;
		public const int FF_BUFFER_HINTS_PRESERVE = 0x4;
		public const int FF_BUFFER_HINTS_REUSABLE = 0x8;
		public const int AV_GET_BUFFER_FLAG_REF = 0x1; // (1 << 0)
		public const int AV_PKT_FLAG_KEY = 0x1;
		public const int AV_PKT_FLAG_CORRUPT = 0x2;
		public const int FF_COMPRESSION_DEFAULT = -0x1; // (-1)
		public const int FF_ASPECT_EXTENDED = 0xf;
		public const int FF_RC_STRATEGY_XVID = 0x1;
		public const int FF_PRED_LEFT = 0x0;
		public const int FF_PRED_PLANE = 0x1;
		public const int FF_PRED_MEDIAN = 0x2;
		public const int FF_CMP_SAD = 0x0;
		public const int FF_CMP_SSE = 0x1;
		public const int FF_CMP_SATD = 0x2;
		public const int FF_CMP_DCT = 0x3;
		public const int FF_CMP_PSNR = 0x4;
		public const int FF_CMP_BIT = 0x5;
		public const int FF_CMP_RD = 0x6;
		public const int FF_CMP_ZERO = 0x7;
		public const int FF_CMP_VSAD = 0x8;
		public const int FF_CMP_VSSE = 0x9;
		public const int FF_CMP_NSSE = 0xa;
		public const int FF_CMP_W53 = 0xb;
		public const int FF_CMP_W97 = 0xc;
		public const int FF_CMP_DCTMAX = 0xd;
		public const int FF_CMP_DCT264 = 0xe;
		public const int FF_CMP_CHROMA = 0x100;
		public const int FF_DTG_AFD_SAME = 0x8;
		public const int FF_DTG_AFD_4_3 = 0x9;
		public const int FF_DTG_AFD_16_9 = 0xa;
		public const int FF_DTG_AFD_14_9 = 0xb;
		public const int FF_DTG_AFD_4_3_SP_14_9 = 0xd;
		public const int FF_DTG_AFD_16_9_SP_14_9 = 0xe;
		public const int FF_DTG_AFD_SP_4_3 = 0xf;
		public const int FF_DEFAULT_QUANT_BIAS = 0xf423f;
		public const int SLICE_FLAG_CODED_ORDER = 0x1;
		public const int SLICE_FLAG_ALLOW_FIELD = 0x2;
		public const int SLICE_FLAG_ALLOW_PLANE = 0x4;
		public const int FF_MB_DECISION_SIMPLE = 0x0;
		public const int FF_MB_DECISION_BITS = 0x1;
		public const int FF_MB_DECISION_RD = 0x2;
		public const int FF_CODER_TYPE_VLC = 0x0;
		public const int FF_CODER_TYPE_AC = 0x1;
		public const int FF_CODER_TYPE_RAW = 0x2;
		public const int FF_CODER_TYPE_RLE = 0x3;
		public const int FF_CODER_TYPE_DEFLATE = 0x4;
		public const int FF_BUG_AUTODETECT = 0x1;
		public const int FF_BUG_OLD_MSMPEG4 = 0x2;
		public const int FF_BUG_XVID_ILACE = 0x4;
		public const int FF_BUG_UMP4 = 0x8;
		public const int FF_BUG_NO_PADDING = 0x10;
		public const int FF_BUG_AMV = 0x20;
		public const int FF_BUG_AC_VLC = 0x0;
		public const int FF_BUG_QPEL_CHROMA = 0x40;
		public const int FF_BUG_STD_QPEL = 0x80;
		public const int FF_BUG_QPEL_CHROMA2 = 0x100;
		public const int FF_BUG_DIRECT_BLOCKSIZE = 0x200;
		public const int FF_BUG_EDGE = 0x400;
		public const int FF_BUG_HPEL_CHROMA = 0x800;
		public const int FF_BUG_DC_CLIP = 0x1000;
		public const int FF_BUG_MS = 0x2000;
		public const int FF_BUG_TRUNCATED = 0x4000;
		public const int FF_COMPLIANCE_VERY_STRICT = 0x2;
		public const int FF_COMPLIANCE_STRICT = 0x1;
		public const int FF_COMPLIANCE_NORMAL = 0x0;
		public const int FF_COMPLIANCE_UNOFFICIAL = -0x1; // (-1)
		public const int FF_COMPLIANCE_EXPERIMENTAL = -0x2; // (-2)
		public const int FF_EC_GUESS_MVS = 0x1;
		public const int FF_EC_DEBLOCK = 0x2;
		public const int FF_EC_FAVOR_INTER = 0x100;
		public const int FF_DEBUG_PICT_INFO = 0x1;
		public const int FF_DEBUG_RC = 0x2;
		public const int FF_DEBUG_BITSTREAM = 0x4;
		public const int FF_DEBUG_MB_TYPE = 0x8;
		public const int FF_DEBUG_QP = 0x10;
		public const int FF_DEBUG_MV = 0x20;
		public const int FF_DEBUG_DCT_COEFF = 0x40;
		public const int FF_DEBUG_SKIP = 0x80;
		public const int FF_DEBUG_STARTCODE = 0x100;
		public const int FF_DEBUG_PTS = 0x200;
		public const int FF_DEBUG_ER = 0x400;
		public const int FF_DEBUG_MMCO = 0x800;
		public const int FF_DEBUG_BUGS = 0x1000;
		public const int FF_DEBUG_VIS_QP = 0x2000;
		public const int FF_DEBUG_VIS_MB_TYPE = 0x4000;
		public const int FF_DEBUG_BUFFERS = 0x8000;
		public const int FF_DEBUG_THREADS = 0x10000;
		public const int FF_DEBUG_NOMC = 0x1000000;
		public const int FF_DEBUG_VIS_MV_P_FOR = 0x1;
		public const int FF_DEBUG_VIS_MV_B_FOR = 0x2;
		public const int FF_DEBUG_VIS_MV_B_BACK = 0x4;
		public const int AV_EF_CRCCHECK = 0x1; // (1 << 0)
		public const int AV_EF_BITSTREAM = 0x2; // (1 << 1)
		public const int AV_EF_BUFFER = 0x4; // (1 << 2)
		public const int AV_EF_EXPLODE = 0x8; // (1 << 3)
		public const int AV_EF_IGNORE_ERR = 0x8000; // (1 << 15)
		public const int AV_EF_CAREFUL = 0x10000; // (1 << 16)
		public const int AV_EF_COMPLIANT = 0x20000; // (1 << 17)
		public const int AV_EF_AGGRESSIVE = 0x40000; // (1 << 18)
		public const int FF_DCT_AUTO = 0x0;
		public const int FF_DCT_FASTINT = 0x1;
		public const int FF_DCT_INT = 0x2;
		public const int FF_DCT_MMX = 0x3;
		public const int FF_DCT_ALTIVEC = 0x5;
		public const int FF_DCT_FAAN = 0x6;
		public const int FF_IDCT_AUTO = 0x0;
		public const int FF_IDCT_INT = 0x1;
		public const int FF_IDCT_SIMPLE = 0x2;
		public const int FF_IDCT_SIMPLEMMX = 0x3;
		public const int FF_IDCT_ARM = 0x7;
		public const int FF_IDCT_ALTIVEC = 0x8;
		public const int FF_IDCT_SH4 = 0x9;
		public const int FF_IDCT_SIMPLEARM = 0xa;
		public const int FF_IDCT_IPP = 0xd;
		public const int FF_IDCT_XVID = 0xe;
		public const int FF_IDCT_XVIDMMX = 0xe;
		public const int FF_IDCT_SIMPLEARMV5TE = 0x10;
		public const int FF_IDCT_SIMPLEARMV6 = 0x11;
		public const int FF_IDCT_SIMPLEVIS = 0x12;
		public const int FF_IDCT_FAAN = 0x14;
		public const int FF_IDCT_SIMPLENEON = 0x16;
		public const int FF_IDCT_SIMPLEALPHA = 0x17;
		public const int FF_IDCT_SIMPLEAUTO = 0x80;
		public const int FF_THREAD_FRAME = 0x1;
		public const int FF_THREAD_SLICE = 0x2;
		public const int FF_PROFILE_UNKNOWN = -0x63; // (-99)
		public const int FF_PROFILE_RESERVED = -0x64; // (-100)
		public const int FF_PROFILE_AAC_MAIN = 0x0;
		public const int FF_PROFILE_AAC_LOW = 0x1;
		public const int FF_PROFILE_AAC_SSR = 0x2;
		public const int FF_PROFILE_AAC_LTP = 0x3;
		public const int FF_PROFILE_AAC_HE = 0x4;
		public const int FF_PROFILE_AAC_HE_V2 = 0x1c;
		public const int FF_PROFILE_AAC_LD = 0x16;
		public const int FF_PROFILE_AAC_ELD = 0x26;
		public const int FF_PROFILE_MPEG2_AAC_LOW = 0x80;
		public const int FF_PROFILE_MPEG2_AAC_HE = 0x83;
		public const int FF_PROFILE_DTS = 0x14;
		public const int FF_PROFILE_DTS_ES = 0x1e;
		public const int FF_PROFILE_DTS_96_24 = 0x28;
		public const int FF_PROFILE_DTS_HD_HRA = 0x32;
		public const int FF_PROFILE_DTS_HD_MA = 0x3c;
		public const int FF_PROFILE_MPEG2_422 = 0x0;
		public const int FF_PROFILE_MPEG2_HIGH = 0x1;
		public const int FF_PROFILE_MPEG2_SS = 0x2;
		public const int FF_PROFILE_MPEG2_SNR_SCALABLE = 0x3;
		public const int FF_PROFILE_MPEG2_MAIN = 0x4;
		public const int FF_PROFILE_MPEG2_SIMPLE = 0x5;
		public const int FF_PROFILE_H264_CONSTRAINED = 0x200; // (1 << 9)
		public const int FF_PROFILE_H264_INTRA = 0x800; // (1 << 11)
		public const int FF_PROFILE_H264_BASELINE = 0x42;
		public const int FF_PROFILE_H264_CONSTRAINED_BASELINE = 0x42; // (66 | FF_PROFILE_H264_CONSTRAINED)
		public const int FF_PROFILE_H264_MAIN = 0x4d;
		public const int FF_PROFILE_H264_EXTENDED = 0x58;
		public const int FF_PROFILE_H264_HIGH = 0x64;
		public const int FF_PROFILE_H264_HIGH_10 = 0x6e;
		public const int FF_PROFILE_H264_HIGH_10_INTRA = 0x6e; // (110 | FF_PROFILE_H264_INTRA)
		public const int FF_PROFILE_H264_HIGH_422 = 0x7a;
		public const int FF_PROFILE_H264_HIGH_422_INTRA = 0x7a; // (122 | FF_PROFILE_H264_INTRA)
		public const int FF_PROFILE_H264_HIGH_444 = 0x90;
		public const int FF_PROFILE_H264_HIGH_444_PREDICTIVE = 0xf4;
		public const int FF_PROFILE_H264_HIGH_444_INTRA = 0xf4; // (244 | FF_PROFILE_H264_INTRA)
		public const int FF_PROFILE_H264_CAVLC_444 = 0x2c;
		public const int FF_PROFILE_VC1_SIMPLE = 0x0;
		public const int FF_PROFILE_VC1_MAIN = 0x1;
		public const int FF_PROFILE_VC1_COMPLEX = 0x2;
		public const int FF_PROFILE_VC1_ADVANCED = 0x3;
		public const int FF_PROFILE_MPEG4_SIMPLE = 0x0;
		public const int FF_PROFILE_MPEG4_SIMPLE_SCALABLE = 0x1;
		public const int FF_PROFILE_MPEG4_CORE = 0x2;
		public const int FF_PROFILE_MPEG4_MAIN = 0x3;
		public const int FF_PROFILE_MPEG4_N_BIT = 0x4;
		public const int FF_PROFILE_MPEG4_SCALABLE_TEXTURE = 0x5;
		public const int FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 0x6;
		public const int FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 0x7;
		public const int FF_PROFILE_MPEG4_HYBRID = 0x8;
		public const int FF_PROFILE_MPEG4_ADVANCED_REAL_TIME = 0x9;
		public const int FF_PROFILE_MPEG4_CORE_SCALABLE = 0xa;
		public const int FF_PROFILE_MPEG4_ADVANCED_CODING = 0xb;
		public const int FF_PROFILE_MPEG4_ADVANCED_CORE = 0xc;
		public const int FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 0xd;
		public const int FF_PROFILE_MPEG4_SIMPLE_STUDIO = 0xe;
		public const int FF_PROFILE_MPEG4_ADVANCED_SIMPLE = 0xf;
		public const int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 0x0;
		public const int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 0x1;
		public const int FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 0x2;
		public const int FF_PROFILE_JPEG2000_DCINEMA_2K = 0x3;
		public const int FF_PROFILE_JPEG2000_DCINEMA_4K = 0x4;
		public const int FF_PROFILE_HEVC_MAIN = 0x1;
		public const int FF_PROFILE_HEVC_MAIN_10 = 0x2;
		public const int FF_PROFILE_HEVC_MAIN_STILL_PICTURE = 0x3;
		public const int FF_PROFILE_HEVC_REXT = 0x4;
		public const int FF_LEVEL_UNKNOWN = -0x63; // (-99)
		public const int FF_SUB_CHARENC_MODE_DO_NOTHING = -0x1; // (-1)
		public const int FF_SUB_CHARENC_MODE_AUTOMATIC = 0x0;
		public const int FF_SUB_CHARENC_MODE_PRE_DECODER = 0x1;
		public const int AV_HWACCEL_FLAG_IGNORE_LEVEL = 0x1; // (1 << 0)
		public const int AV_SUBTITLE_FLAG_FORCED = 0x1;
		public const int AV_PARSER_PTS_NB = 0x4;
		public const int PARSER_FLAG_COMPLETE_FRAMES = 0x1;
		public const int PARSER_FLAG_ONCE = 0x2;
		public const int PARSER_FLAG_FETCHED_OFFSET = 0x4;
		public const int PARSER_FLAG_USE_CODEC_TS = 0x1000;
		public const int LIBAVDEVICE_VERSION_MAJOR = 0x38;
		public const int LIBAVDEVICE_VERSION_MINOR = 0x3;
		public const int LIBAVDEVICE_VERSION_MICRO = 0x64;
		public const int LIBAVDEVICE_BUILD = 0x0; // LIBAVDEVICE_VERSION_INT
		public const int AV_OPT_FLAG_ENCODING_PARAM = 0x1;
		public const int AV_OPT_FLAG_DECODING_PARAM = 0x2;
		public const int AV_OPT_FLAG_METADATA = 0x4;
		public const int AV_OPT_FLAG_AUDIO_PARAM = 0x8;
		public const int AV_OPT_FLAG_VIDEO_PARAM = 0x10;
		public const int AV_OPT_FLAG_SUBTITLE_PARAM = 0x20;
		public const int AV_OPT_FLAG_EXPORT = 0x40;
		public const int AV_OPT_FLAG_READONLY = 0x80;
		public const int AV_OPT_FLAG_FILTERING_PARAM = 0x10000; // (1 << 16)
		public const int AV_OPT_SEARCH_CHILDREN = 0x1;
		public const int AV_OPT_SEARCH_FAKE_OBJ = 0x2;
		public const int AV_OPT_MULTI_COMPONENT_RANGE = 0x1000;
		public const int AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x1;
		public const int AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x2;
		public const int LIBAVFORMAT_VERSION_MAJOR = 0x38;
		public const int LIBAVFORMAT_VERSION_MINOR = 0xf;
		public const int LIBAVFORMAT_VERSION_MICRO = 0x66;
		public const int LIBAVFORMAT_BUILD = 0x0; // LIBAVFORMAT_VERSION_INT
		public const int FF_API_LAVF_BITEXACT = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 57)
		public const int FF_API_LAVF_FRAC = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 57)
		public const int FF_API_LAVF_CODEC_TB = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 57)
		public const int FF_API_URL_FEOF = 0x1; // (LIBAVFORMAT_VERSION_MAJOR < 57)
		public const int FF_API_R_FRAME_RATE = 0x1;
		public const int AVIO_SEEKABLE_NORMAL = 0x1;
		public const int AVSEEK_SIZE = 0x10000;
		public const int AVSEEK_FORCE = 0x20000;
		public const int AVIO_FLAG_READ = 0x1;
		public const int AVIO_FLAG_WRITE = 0x2;
		public const int AVIO_FLAG_READ_WRITE = 0x0; // (AVIO_FLAG_READ | AVIO_FLAG_WRITE)
		public const int AVIO_FLAG_NONBLOCK = 0x8;
		public const int AVIO_FLAG_DIRECT = 0x8000;
		public const int AVPROBE_SCORE_RETRY = 0x0; // (AVPROBE_SCORE_MAX / 4)
		public const int AVPROBE_SCORE_STREAM_RETRY = -0x1; // ((AVPROBE_SCORE_MAX / 4) - 1)
		public const int AVPROBE_SCORE_EXTENSION = 0x32;
		public const int AVPROBE_SCORE_MIME = 0x4b;
		public const int AVPROBE_SCORE_MAX = 0x64;
		public const int AVPROBE_PADDING_SIZE = 0x20;
		public const int AVFMT_NOFILE = 0x1;
		public const int AVFMT_NEEDNUMBER = 0x2;
		public const int AVFMT_SHOW_IDS = 0x8;
		public const int AVFMT_RAWPICTURE = 0x20;
		public const int AVFMT_GLOBALHEADER = 0x40;
		public const int AVFMT_NOTIMESTAMPS = 0x80;
		public const int AVFMT_GENERIC_INDEX = 0x100;
		public const int AVFMT_TS_DISCONT = 0x200;
		public const int AVFMT_VARIABLE_FPS = 0x400;
		public const int AVFMT_NODIMENSIONS = 0x800;
		public const int AVFMT_NOSTREAMS = 0x1000;
		public const int AVFMT_NOBINSEARCH = 0x2000;
		public const int AVFMT_NOGENSEARCH = 0x4000;
		public const int AVFMT_NO_BYTE_SEEK = 0x8000;
		public const int AVFMT_ALLOW_FLUSH = 0x10000;
		public const int AVFMT_TS_NONSTRICT = 0x20000;
		public const int AVFMT_TS_NEGATIVE = 0x40000;
		public const int AVFMT_SEEK_TO_PTS = 0x4000000;
		public const int AVINDEX_KEYFRAME = 0x1;
		public const int AV_DISPOSITION_DEFAULT = 0x1;
		public const int AV_DISPOSITION_DUB = 0x2;
		public const int AV_DISPOSITION_ORIGINAL = 0x4;
		public const int AV_DISPOSITION_COMMENT = 0x8;
		public const int AV_DISPOSITION_LYRICS = 0x10;
		public const int AV_DISPOSITION_KARAOKE = 0x20;
		public const int AV_DISPOSITION_FORCED = 0x40;
		public const int AV_DISPOSITION_HEARING_IMPAIRED = 0x80;
		public const int AV_DISPOSITION_VISUAL_IMPAIRED = 0x100;
		public const int AV_DISPOSITION_CLEAN_EFFECTS = 0x200;
		public const int AV_DISPOSITION_ATTACHED_PIC = 0x400;
		public const int AV_DISPOSITION_CAPTIONS = 0x10000;
		public const int AV_DISPOSITION_DESCRIPTIONS = 0x20000;
		public const int AV_DISPOSITION_METADATA = 0x40000;
		public const int AV_PTS_WRAP_IGNORE = 0x0;
		public const int AV_PTS_WRAP_ADD_OFFSET = 0x1;
		public const int AV_PTS_WRAP_SUB_OFFSET = -0x1; // (-1)
		public const int AVSTREAM_EVENT_FLAG_METADATA_UPDATED = 0x1;
		public const int MAX_STD_TIMEBASES = 0x175; // (((30 * 12) + 7) + 6)
		public const int MAX_PROBE_PACKETS = 0x9c4;
		public const int MAX_REORDER_DELAY = 0x10;
		public const int AV_PROGRAM_RUNNING = 0x1;
		public const int AVFMTCTX_NOHEADER = 0x1;
		public const int AVFMT_FLAG_GENPTS = 0x1;
		public const int AVFMT_FLAG_IGNIDX = 0x2;
		public const int AVFMT_FLAG_NONBLOCK = 0x4;
		public const int AVFMT_FLAG_IGNDTS = 0x8;
		public const int AVFMT_FLAG_NOFILLIN = 0x10;
		public const int AVFMT_FLAG_NOPARSE = 0x20;
		public const int AVFMT_FLAG_NOBUFFER = 0x40;
		public const int AVFMT_FLAG_CUSTOM_IO = 0x80;
		public const int AVFMT_FLAG_DISCARD_CORRUPT = 0x100;
		public const int AVFMT_FLAG_FLUSH_PACKETS = 0x200;
		public const int AVFMT_FLAG_BITEXACT = 0x400;
		public const int AVFMT_FLAG_MP4A_LATM = 0x8000;
		public const int AVFMT_FLAG_SORT_DTS = 0x10000;
		public const int AVFMT_FLAG_PRIV_OPT = 0x20000;
		public const int AVFMT_FLAG_KEEP_SIDE_DATA = 0x40000;
		public const int FF_FDEBUG_TS = 0x1;
		public const int AVFMT_EVENT_FLAG_METADATA_UPDATED = 0x1;
		public const int AVFMT_AVOID_NEG_TS_AUTO = -0x1; // (-1)
		public const int AVFMT_AVOID_NEG_TS_MAKE_NON_NEGATIVE = 0x1;
		public const int AVFMT_AVOID_NEG_TS_MAKE_ZERO = 0x2;
		public const int RAW_PACKET_BUFFER_SIZE = 0x2625a0;
		public const int AVSEEK_FLAG_BACKWARD = 0x1;
		public const int AVSEEK_FLAG_BYTE = 0x2;
		public const int AVSEEK_FLAG_ANY = 0x4;
		public const int AVSEEK_FLAG_FRAME = 0x8;
		public const int LIBAVFILTER_VERSION_MAJOR = 0x5;
		public const int LIBAVFILTER_VERSION_MINOR = 0x2;
		public const int LIBAVFILTER_VERSION_MICRO = 0x67;
		public const int LIBAVFILTER_BUILD = 0x0; // LIBAVFILTER_VERSION_INT
		public const int FF_API_AVFILTERPAD_PUBLIC = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int FF_API_FOO_COUNT = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int FF_API_AVFILTERBUFFER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int FF_API_OLD_FILTER_OPTS = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int FF_API_AVFILTER_OPEN = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int FF_API_AVFILTER_INIT_FILTER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int FF_API_OLD_FILTER_REGISTER = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int FF_API_OLD_GRAPH_PARSE = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 5)
		public const int FF_API_NOCONST_GET_NAME = 0x1; // (LIBAVFILTER_VERSION_MAJOR < 6)
		public const int AV_PERM_READ = 0x1;
		public const int AV_PERM_WRITE = 0x2;
		public const int AV_PERM_PRESERVE = 0x4;
		public const int AV_PERM_REUSE = 0x8;
		public const int AV_PERM_REUSE2 = 0x10;
		public const int AV_PERM_NEG_LINESIZES = 0x20;
		public const int AV_PERM_ALIGN = 0x40;
		public const int AVFILTER_ALIGN = 0x10;
		public const int AVFILTER_FLAG_DYNAMIC_INPUTS = 0x1; // (1 << 0)
		public const int AVFILTER_FLAG_DYNAMIC_OUTPUTS = 0x2; // (1 << 1)
		public const int AVFILTER_FLAG_SLICE_THREADS = 0x4; // (1 << 2)
		public const int AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = 0x10000; // (1 << 16)
		public const int AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = 0x20000; // (1 << 17)
		public const int AVFILTER_FLAG_SUPPORT_TIMELINE = 0x0; // (AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL)
		public const int AVFILTER_THREAD_SLICE = 0x1; // (1 << 0)
		public const int AVFILTER_CMD_FLAG_ONE = 0x1;
		public const int AVFILTER_CMD_FLAG_FAST = 0x2;
		public const int AV_BUFFERSINK_FLAG_PEEK = 0x1;
		public const int AV_BUFFERSINK_FLAG_NO_REQUEST = 0x2;
		public const int AV_PIX_FMT_FLAG_BE = 0x1; // (1 << 0)
		public const int AV_PIX_FMT_FLAG_PAL = 0x2; // (1 << 1)
		public const int AV_PIX_FMT_FLAG_BITSTREAM = 0x4; // (1 << 2)
		public const int AV_PIX_FMT_FLAG_HWACCEL = 0x8; // (1 << 3)
		public const int AV_PIX_FMT_FLAG_PLANAR = 0x10; // (1 << 4)
		public const int AV_PIX_FMT_FLAG_RGB = 0x20; // (1 << 5)
		public const int AV_PIX_FMT_FLAG_PSEUDOPAL = 0x40; // (1 << 6)
		public const int AV_PIX_FMT_FLAG_ALPHA = 0x80; // (1 << 7)
		public const int PIX_FMT_BE = 0x0; // AV_PIX_FMT_FLAG_BE
		public const int PIX_FMT_PAL = 0x0; // AV_PIX_FMT_FLAG_PAL
		public const int PIX_FMT_BITSTREAM = 0x0; // AV_PIX_FMT_FLAG_BITSTREAM
		public const int PIX_FMT_HWACCEL = 0x0; // AV_PIX_FMT_FLAG_HWACCEL
		public const int PIX_FMT_PLANAR = 0x0; // AV_PIX_FMT_FLAG_PLANAR
		public const int PIX_FMT_RGB = 0x0; // AV_PIX_FMT_FLAG_RGB
		public const int PIX_FMT_PSEUDOPAL = 0x0; // AV_PIX_FMT_FLAG_PSEUDOPAL
		public const int PIX_FMT_ALPHA = 0x0; // AV_PIX_FMT_FLAG_ALPHA
		public const int FF_LOSS_RESOLUTION = 0x1;
		public const int FF_LOSS_DEPTH = 0x2;
		public const int FF_LOSS_COLORSPACE = 0x4;
		public const int FF_LOSS_ALPHA = 0x8;
		public const int FF_LOSS_COLORQUANT = 0x10;
		public const int FF_LOSS_CHROMA = 0x20;
		public const int LIBPOSTPROC_VERSION_MAJOR = 0x35;
		public const int LIBPOSTPROC_VERSION_MINOR = 0x3;
		public const int LIBPOSTPROC_VERSION_MICRO = 0x64;
		public const int LIBPOSTPROC_BUILD = 0x0; // LIBPOSTPROC_VERSION_INT
		public const int PP_QUALITY_MAX = 0x6;
		public const long PP_CPU_CAPS_MMX = 0x80000000L; // 2147483648L
		public const int PP_CPU_CAPS_MMX2 = 0x20000000;
		public const int PP_CPU_CAPS_3DNOW = 0x40000000;
		public const int PP_CPU_CAPS_ALTIVEC = 0x10000000;
		public const int PP_CPU_CAPS_AUTO = 0x80000;
		public const int PP_FORMAT = 0x8;
		public const int PP_FORMAT_420 = 0x11; // (17 | PP_FORMAT)
		public const int PP_FORMAT_422 = 0x1; // (1 | PP_FORMAT)
		public const int PP_FORMAT_411 = 0x2; // (2 | PP_FORMAT)
		public const int PP_FORMAT_444 = 0x0; // (0 | PP_FORMAT)
		public const int PP_FORMAT_440 = 0x10; // (16 | PP_FORMAT)
		public const int PP_PICT_TYPE_QP2 = 0x10;
		public const int LIBSWRESAMPLE_VERSION_MAJOR = 0x1;
		public const int LIBSWRESAMPLE_VERSION_MINOR = 0x1;
		public const int LIBSWRESAMPLE_VERSION_MICRO = 0x64;
		public const int LIBSWRESAMPLE_BUILD = 0x0; // LIBSWRESAMPLE_VERSION_INT
		public const int SWR_FLAG_RESAMPLE = 0x1;
		public const int LIBSWSCALE_VERSION_MAJOR = 0x3;
		public const int LIBSWSCALE_VERSION_MINOR = 0x1;
		public const int LIBSWSCALE_VERSION_MICRO = 0x65;
		public const int LIBSWSCALE_BUILD = 0x0; // LIBSWSCALE_VERSION_INT
		public const int FF_API_SWS_CPU_CAPS = 0x1; // (LIBSWSCALE_VERSION_MAJOR < 4)
		public const int FF_API_ARCH_BFIN = 0x1; // (LIBSWSCALE_VERSION_MAJOR < 4)
		public const int SWS_FAST_BILINEAR = 0x1;
		public const int SWS_BILINEAR = 0x2;
		public const int SWS_BICUBIC = 0x4;
		public const int SWS_X = 0x8;
		public const int SWS_POINT = 0x10;
		public const int SWS_AREA = 0x20;
		public const int SWS_BICUBLIN = 0x40;
		public const int SWS_GAUSS = 0x80;
		public const int SWS_SINC = 0x100;
		public const int SWS_LANCZOS = 0x200;
		public const int SWS_SPLINE = 0x400;
		public const int SWS_SRC_V_CHR_DROP_MASK = 0x30000;
		public const int SWS_SRC_V_CHR_DROP_SHIFT = 0x10;
		public const int SWS_PARAM_DEFAULT = 0x1e240;
		public const int SWS_PRINT_INFO = 0x1000;
		public const int SWS_FULL_CHR_H_INT = 0x2000;
		public const int SWS_FULL_CHR_H_INP = 0x4000;
		public const int SWS_DIRECT_BGR = 0x8000;
		public const int SWS_ACCURATE_RND = 0x40000;
		public const int SWS_BITEXACT = 0x80000;
		public const int SWS_ERROR_DIFFUSION = 0x800000;
		public const long SWS_CPU_CAPS_MMX = 0x80000000L; // 2147483648L
		public const int SWS_CPU_CAPS_MMXEXT = 0x20000000;
		public const int SWS_CPU_CAPS_MMX2 = 0x20000000;
		public const int SWS_CPU_CAPS_3DNOW = 0x40000000;
		public const int SWS_CPU_CAPS_ALTIVEC = 0x10000000;
		public const int SWS_CPU_CAPS_BFIN = 0x1000000;
		public const int SWS_CPU_CAPS_SSE2 = 0x2000000;
		public const float SWS_MAX_REDUCE_CUTOFF = 0.002000f;
		public const int SWS_CS_ITU709 = 0x1;
		public const int SWS_CS_FCC = 0x4;
		public const int SWS_CS_ITU601 = 0x5;
		public const int SWS_CS_ITU624 = 0x5;
		public const int SWS_CS_SMPTE170M = 0x5;
		public const int SWS_CS_SMPTE240M = 0x7;
		public const int SWS_CS_DEFAULT = 0x5;
		
		// Func<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avutil_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avutil_version();
		
		// Func<String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avutil_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avutil_configuration();
		
		// Func<String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avutil_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avutil_license();
		
		// Func<AVMediaType, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_media_type_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_media_type_string(AVMediaType media_type);
		
		// Func<AVPictureType, sbyte>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_picture_type_char", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern sbyte av_get_picture_type_char(AVPictureType pict_type);
		
		// Func<int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_log2(int v);
		
		// Func<int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log2_16bit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_log2_16bit(int v);
		
		// Func<int, String, uint, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_strerror", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_strerror(int errnum, sbyte* /*String*/ errbuf, uint errbuf_size);
		
		// Func<uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_malloc(uint size);
		
		// Func<void*, uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_realloc(void* ptr, uint size);
		
		// Func<void*, uint, uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_realloc_f", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_realloc_f(void* ptr, uint nelem, uint elsize);
		
		// Func<void*, uint, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_reallocp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_reallocp(void* ptr, uint size);
		
		// Func<void*, uint, uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_realloc_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_realloc_array(void* ptr, uint nmemb, uint size);
		
		// Func<void*, uint, uint, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_reallocp_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_reallocp_array(void* ptr, uint nmemb, uint size);
		
		// Action<void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_free(void* ptr);
		
		// Func<uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_mallocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_mallocz(uint size);
		
		// Func<uint, uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_calloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_calloc(uint nmemb, uint size);
		
		// Func<String, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_strdup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_strdup(String s);
		
		// Func<String, uint, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_strndup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_strndup(String s, uint len);
		
		// Func<void*, uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_memdup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_memdup(void* p, uint size);
		
		// Action<void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_freep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_freep(void* ptr);
		
		// Action<void*, int*, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dynarray_add", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dynarray_add(void* tab_ptr, int* nb_ptr, void* elem);
		
		// Func<void*, int*, void*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dynarray_add_nofree", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dynarray_add_nofree(void* tab_ptr, int* nb_ptr, void* elem);
		
		// Func<void**, int*, uint, byte*, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dynarray2_add", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_dynarray2_add(void** tab_ptr, int* nb_ptr, uint elem_size, byte* elem_data);
		
		// Action<uint>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_max_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_max_alloc(uint max);
		
		// Action<byte*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_memcpy_backptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_memcpy_backptr(byte* dst, int back, int cnt);
		
		// Func<void*, int*, uint, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fast_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_fast_realloc(void* ptr, int* size, uint min_size);
		
		// Action<void*, int*, uint>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fast_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fast_malloc(void* ptr, int* size, uint min_size);
		
		// Func<int*, int*, long, long, long, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_reduce", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_reduce(int* dst_num, int* dst_den, long num, long den, long max);
		
		// Func<AVRational, AVRational, AVRational>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_mul_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_mul_q(AVRational b, AVRational c);
		
		// Func<AVRational, AVRational, AVRational>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_div_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_div_q(AVRational b, AVRational c);
		
		// Func<AVRational, AVRational, AVRational>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_add_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_add_q(AVRational b, AVRational c);
		
		// Func<AVRational, AVRational, AVRational>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_sub_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_sub_q(AVRational b, AVRational c);
		
		// Func<double, int, AVRational>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_d2q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_d2q(double d, int max);
		
		// Func<AVRational, AVRational, AVRational, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_nearer_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_nearer_q(AVRational q, AVRational q1, AVRational q2);
		
		// Func<AVRational, AVRational*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_find_nearest_q_idx", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_find_nearest_q_idx(AVRational q, AVRational* q_list);
		
		// Func<long, long, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_gcd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_gcd(long a, long b);
		
		// Func<long, long, long, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale(long a, long b, long c);
		
		// Func<long, long, long, AVRounding, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_rnd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_rnd(long a, long b, long c, AVRounding p3);
		
		// Func<long, AVRational, AVRational, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_q(long a, AVRational bq, AVRational cq);
		
		// Func<long, AVRational, AVRational, AVRounding, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_q_rnd", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_q_rnd(long a, AVRational bq, AVRational cq, AVRounding p3);
		
		// Func<long, AVRational, long, AVRational, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_compare_ts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_compare_ts(long ts_a, AVRational tb_a, long ts_b, AVRational tb_b);
		
		// Func<ulong, ulong, ulong, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_compare_mod", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_compare_mod(ulong a, ulong b, ulong mod);
		
		// Func<AVRational, long, AVRational, int, long*, AVRational, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_rescale_delta", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_rescale_delta(AVRational in_tb, long in_ts, AVRational fs_tb, int duration, long* last, AVRational out_tb);
		
		// Func<AVRational, long, AVRational, long, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_add_stable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_add_stable(AVRational ts_tb, long ts, AVRational inc_tb, long inc);
		
		// Action<void*, int, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log(void* avcl, int level, String fmt);
		
		// Func<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_get_level", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_log_get_level();
		
		// Action<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_set_level", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_set_level(int level);
		
		// Func<void*, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_default_item_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_default_item_name(void* ctx);
		
		// Func<void*, AVClassCategory>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_default_get_category", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern Anon5 av_default_get_category(void* ptr);
		
		// Action<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_set_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_set_flags(int arg);
		
		// Func<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_log_get_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_log_get_flags();
		
		// Func<int, void*, ulong, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_int_list_length_for_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_int_list_length_for_size(int elsize, void* list, ulong term);
		
		// Func<String, String, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fopen_utf8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_fopen_utf8(String path, String mode);
		
		// Func<AVRational>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_time_base_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_get_time_base_q();
		
		// Func<AVSampleFormat, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_sample_fmt_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_sample_fmt_name(AVSampleFormat sample_fmt);
		
		// Func<String, AVSampleFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_sample_fmt(String name);
		
		// Func<AVSampleFormat, int, AVSampleFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_alt_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat sample_fmt, int planar);
		
		// Func<AVSampleFormat, AVSampleFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_packed_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat sample_fmt);
		
		// Func<AVSampleFormat, AVSampleFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_planar_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat sample_fmt);
		
		// Func<String, int, AVSampleFormat, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_sample_fmt_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_sample_fmt_string(sbyte* /*String*/ buf, int buf_size, AVSampleFormat sample_fmt);
		
		// Func<AVSampleFormat, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_bytes_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_bytes_per_sample(AVSampleFormat sample_fmt);
		
		// Func<AVSampleFormat, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_sample_fmt_is_planar", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_sample_fmt_is_planar(AVSampleFormat sample_fmt);
		
		// Func<int*, int, int, AVSampleFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_get_buffer_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_get_buffer_size(int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		
		// Func<byte**, int*, byte*, int, int, AVSampleFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_fill_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_fill_arrays(byte** audio_data, int* linesize, byte* buf, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		
		// Func<byte**, int*, int, int, AVSampleFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_alloc(byte** audio_data, int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		
		// Func<byte***, int*, int, int, AVSampleFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_alloc_array_and_samples", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_alloc_array_and_samples(byte*** audio_data, int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
		
		// Func<byte**, byte**, int, int, int, int, AVSampleFormat, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_copy(byte** dst, byte** src, int dst_offset, int src_offset, int nb_samples, int nb_channels, AVSampleFormat sample_fmt);
		
		// Func<byte**, int, int, int, AVSampleFormat, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_samples_set_silence", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_samples_set_silence(byte** audio_data, int offset, int nb_samples, int nb_channels, AVSampleFormat sample_fmt);
		
		// Func<int, AVBufferRef*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_alloc(int size);
		
		// Func<int, AVBufferRef*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_allocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_allocz(int size);
		
		// Func<byte*, int, Action<void*, byte*>, void*, int, AVBufferRef*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_create(byte* data, int size, IntPtr func_opaque_data_2, void* opaque, int flags);
		
		// Action<void*, byte*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_default_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_buffer_default_free(void* opaque, byte* data);
		
		// Func<AVBufferRef*, AVBufferRef*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_ref(AVBufferRef* buf);
		
		// Action<AVBufferRef**>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_buffer_unref(AVBufferRef** buf);
		
		// Func<AVBufferRef*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_is_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_is_writable(AVBufferRef* buf);
		
		// Func<AVBufferRef*, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_get_opaque", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_buffer_get_opaque(AVBufferRef* buf);
		
		// Func<AVBufferRef*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_get_ref_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_get_ref_count(AVBufferRef* buf);
		
		// Func<AVBufferRef**, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_make_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_make_writable(AVBufferRef** buf);
		
		// Func<AVBufferRef**, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffer_realloc(AVBufferRef** buf, int size);
		
		// Func<int, Func<int, AVBufferRef*>, AVBufferPool*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_pool_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferPool* av_buffer_pool_init(int size, IntPtr func_size_1);
		
		// Action<AVBufferPool**>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_pool_uninit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_buffer_pool_uninit(AVBufferPool** pool);
		
		// Func<AVBufferPool*, AVBufferRef*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_buffer_pool_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* pool);
		
		// Func<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_cpu_flags();
		
		// Action<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_force_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_force_cpu_flags(int flags);
		
		// Action<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_set_cpu_flags_mask", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_set_cpu_flags_mask(int mask);
		
		// Func<String, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_parse_cpu_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parse_cpu_flags(String s);
		
		// Func<int*, String, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_parse_cpu_caps", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parse_cpu_caps(int* flags, String s);
		
		// Func<int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_cpu_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_cpu_count();
		
		// Func<String, ulong>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong av_get_channel_layout(String name);
		
		// Action<String, int, int, ulong>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_get_channel_layout_string(sbyte* /*String*/ buf, int buf_size, int nb_channels, ulong channel_layout);
		
		// Action<AVBPrint*, int, ulong>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_bprint_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_bprint_channel_layout(AVBPrint* bp, int nb_channels, ulong channel_layout);
		
		// Func<ulong, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout_nb_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_channel_layout_nb_channels(ulong channel_layout);
		
		// Func<int, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_default_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_get_default_channel_layout(int nb_channels);
		
		// Func<ulong, ulong, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_layout_channel_index", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_channel_layout_channel_index(ulong channel_layout, ulong channel);
		
		// Func<ulong, int, ulong>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_channel_layout_extract_channel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong av_channel_layout_extract_channel(ulong channel_layout, int index);
		
		// Func<ulong, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_channel_name(ulong channel);
		
		// Func<ulong, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_channel_description", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_channel_description(ulong channel);
		
		// Func<int, ulong*, sbyte**, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_standard_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_standard_channel_layout(int index, ulong* layout, sbyte** name);
		
		// Func<AVDictionary*, String, AVDictionaryEntry*, int, AVDictionaryEntry*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDictionaryEntry* av_dict_get(AVDictionary* m, String key, AVDictionaryEntry* prev, int flags);
		
		// Func<AVDictionary*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_count(AVDictionary* m);
		
		// Func<AVDictionary**, String, String, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_set(AVDictionary** pm, String key, String value, int flags);
		
		// Func<AVDictionary**, String, long, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_set_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_set_int(AVDictionary** pm, String key, long value, int flags);
		
		// Func<AVDictionary**, String, String, String, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_parse_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_parse_string(AVDictionary** pm, String str, String key_val_sep, String pairs_sep, int flags);
		
		// Action<AVDictionary**, AVDictionary*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dict_copy(AVDictionary** dst, AVDictionary* src, int flags);
		
		// Action<AVDictionary**>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dict_free(AVDictionary** m);
		
		// Func<AVDictionary*, sbyte**, sbyte, sbyte, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_dict_get_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dict_get_string(AVDictionary* m, sbyte** buffer, sbyte key_val_sep, sbyte pairs_sep);
		
		// Func<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_best_effort_timestamp(AVFrame* frame);
		
		// Action<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_best_effort_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_best_effort_timestamp(AVFrame* frame, long val);
		
		// Func<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_pkt_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_pkt_duration(AVFrame* frame);
		
		// Action<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_pkt_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_pkt_duration(AVFrame* frame, long val);
		
		// Func<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_pkt_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_pkt_pos(AVFrame* frame);
		
		// Action<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_pkt_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_pkt_pos(AVFrame* frame, long val);
		
		// Func<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_frame_get_channel_layout(AVFrame* frame);
		
		// Action<AVFrame*, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_channel_layout(AVFrame* frame, long val);
		
		// Func<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_channels(AVFrame* frame);
		
		// Action<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_channels(AVFrame* frame, int val);
		
		// Func<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_sample_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_sample_rate(AVFrame* frame);
		
		// Action<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_sample_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_sample_rate(AVFrame* frame, int val);
		
		// Func<AVFrame*, AVDictionary*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_metadata", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDictionary* av_frame_get_metadata(AVFrame* frame);
		
		// Action<AVFrame*, AVDictionary*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_metadata", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_metadata(AVFrame* frame, AVDictionary* val);
		
		// Func<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_decode_error_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_decode_error_flags(AVFrame* frame);
		
		// Action<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_decode_error_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_decode_error_flags(AVFrame* frame, int val);
		
		// Func<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_pkt_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_pkt_size(AVFrame* frame);
		
		// Action<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_pkt_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_pkt_size(AVFrame* frame, int val);
		
		// Func<AVFrame*, AVDictionary**>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="avpriv_frame_get_metadatap", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDictionary** avpriv_frame_get_metadatap(AVFrame* frame);
		
		// Func<AVFrame*, int*, int*, sbyte*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_qp_table", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern sbyte* av_frame_get_qp_table(AVFrame* f, int* stride, int* type);
		
		// Func<AVFrame*, AVBufferRef*, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_qp_table", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_set_qp_table(AVFrame* f, AVBufferRef* buf, int stride, int type);
		
		// Func<AVFrame*, AVColorSpace>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_colorspace", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVColorSpace av_frame_get_colorspace(AVFrame* frame);
		
		// Action<AVFrame*, AVColorSpace>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_colorspace", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_colorspace(AVFrame* frame, AVColorSpace val);
		
		// Func<AVFrame*, AVColorRange>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_color_range", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVColorRange av_frame_get_color_range(AVFrame* frame);
		
		// Action<AVFrame*, AVColorRange>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_set_color_range", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_set_color_range(AVFrame* frame, AVColorRange val);
		
		// Func<AVColorSpace, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_colorspace_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_colorspace_name(AVColorSpace val);
		
		// Func<AVFrame*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrame* av_frame_alloc();
		
		// Action<AVFrame**>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_free(AVFrame** frame);
		
		// Func<AVFrame*, AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_ref(AVFrame* dst, AVFrame* src);
		
		// Func<AVFrame*, AVFrame*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_clone", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrame* av_frame_clone(AVFrame* src);
		
		// Action<AVFrame*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_unref(AVFrame* frame);
		
		// Action<AVFrame*, AVFrame*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_move_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_move_ref(AVFrame* dst, AVFrame* src);
		
		// Func<AVFrame*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_get_buffer(AVFrame* frame, int align);
		
		// Func<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_is_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_is_writable(AVFrame* frame);
		
		// Func<AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_make_writable", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_make_writable(AVFrame* frame);
		
		// Func<AVFrame*, AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_copy(AVFrame* dst, AVFrame* src);
		
		// Func<AVFrame*, AVFrame*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_copy_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_frame_copy_props(AVFrame* dst, AVFrame* src);
		
		// Func<AVFrame*, int, AVBufferRef*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_plane_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBufferRef* av_frame_get_plane_buffer(AVFrame* frame, int plane);
		
		// Func<AVFrame*, AVFrameSideDataType, int, AVFrameSideData*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_new_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* frame, AVFrameSideDataType type, int size);
		
		// Func<AVFrame*, AVFrameSideDataType, AVFrameSideData*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrameSideData* av_frame_get_side_data(AVFrame* frame, AVFrameSideDataType type);
		
		// Action<AVFrame*, AVFrameSideDataType>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_remove_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_frame_remove_side_data(AVFrame* frame, AVFrameSideDataType type);
		
		// Func<AVFrameSideDataType, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_frame_side_data_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_frame_side_data_name(AVFrameSideDataType type);
		
		// Func<AVCodecContext*, AVRational>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_pkt_timebase", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_codec_get_pkt_timebase(AVCodecContext* avctx);
		
		// Action<AVCodecContext*, AVRational>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_pkt_timebase", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_pkt_timebase(AVCodecContext* avctx, AVRational val);
		
		// Func<AVCodecContext*, AVCodecDescriptor*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_codec_descriptor", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* av_codec_get_codec_descriptor(AVCodecContext* avctx);
		
		// Action<AVCodecContext*, AVCodecDescriptor*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_codec_descriptor", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_codec_descriptor(AVCodecContext* avctx, AVCodecDescriptor* desc);
		
		// Func<AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_lowres(AVCodecContext* avctx);
		
		// Action<AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_lowres(AVCodecContext* avctx, int val);
		
		// Func<AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_seek_preroll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_seek_preroll(AVCodecContext* avctx);
		
		// Action<AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_seek_preroll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_seek_preroll(AVCodecContext* avctx, int val);
		
		// Func<AVCodecContext*, ushort*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_chroma_intra_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ushort* av_codec_get_chroma_intra_matrix(AVCodecContext* avctx);
		
		// Action<AVCodecContext*, ushort*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_set_chroma_intra_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_codec_set_chroma_intra_matrix(AVCodecContext* avctx, ushort* val);
		
		// Func<AVCodec*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_get_max_lowres", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_max_lowres(AVCodec* codec);
		
		// Func<AVCodec*, AVCodec*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* av_codec_next(AVCodec* c);
		
		// Func<int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_version();
		
		// Func<String>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avcodec_configuration();
		
		// Func<String>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avcodec_license();
		
		// Action<AVCodec*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_register(AVCodec* codec);
		
		// Action
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_register_all();
		
		// Func<AVCodec*, AVCodecContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_alloc_context3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecContext* avcodec_alloc_context3(AVCodec* codec);
		
		// Action<AVCodecContext**>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_free_context(AVCodecContext** avctx);
		
		// Func<AVCodecContext*, AVCodec*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_context_defaults3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_get_context_defaults3(AVCodecContext* s, AVCodec* codec);
		
		// Func<AVClass*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avcodec_get_class();
		
		// Func<AVClass*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_frame_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avcodec_get_frame_class();
		
		// Func<AVClass*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_subtitle_rect_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avcodec_get_subtitle_rect_class();
		
		// Func<AVCodecContext*, AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_copy_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_copy_context(AVCodecContext* dest, AVCodecContext* src);
		
		// Func<AVFrame*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_alloc_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFrame* avcodec_alloc_frame();
		
		// Action<AVFrame*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_frame_defaults", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_get_frame_defaults(AVFrame* frame);
		
		// Action<AVFrame**>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_free_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_free_frame(AVFrame** frame);
		
		// Func<AVCodecContext*, AVCodec*, AVDictionary**, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_open2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_open2(AVCodecContext* avctx, AVCodec* codec, AVDictionary** options);
		
		// Func<AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_close(AVCodecContext* avctx);
		
		// Action<AVSubtitle*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avsubtitle_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avsubtitle_free(AVSubtitle* sub);
		
		// Action<AVPacket*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_destruct_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_destruct_packet(AVPacket* pkt);
		
		// Action<AVPacket*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_init_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_init_packet(AVPacket* pkt);
		
		// Func<AVPacket*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_new_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_new_packet(AVPacket* pkt, int size);
		
		// Action<AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_shrink_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_shrink_packet(AVPacket* pkt, int size);
		
		// Func<AVPacket*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_grow_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_grow_packet(AVPacket* pkt, int grow_by);
		
		// Func<AVPacket*, byte*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_from_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_from_data(AVPacket* pkt, byte* data, int size);
		
		// Func<AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_dup_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_dup_packet(AVPacket* pkt);
		
		// Func<AVPacket*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_copy_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_copy_packet(AVPacket* dst, AVPacket* src);
		
		// Func<AVPacket*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_copy_packet_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_copy_packet_side_data(AVPacket* dst, AVPacket* src);
		
		// Action<AVPacket*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_free_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_free_packet(AVPacket* pkt);
		
		// Func<AVPacket*, AVPacketSideDataType, int, byte*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_new_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern byte* av_packet_new_side_data(AVPacket* pkt, AVPacketSideDataType type, int size);
		
		// Func<AVPacket*, AVPacketSideDataType, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_shrink_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_shrink_side_data(AVPacket* pkt, AVPacketSideDataType type, int size);
		
		// Func<AVPacket*, AVPacketSideDataType, int*, byte*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern byte* av_packet_get_side_data(AVPacket* pkt, AVPacketSideDataType type, int* size);
		
		// Func<AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_merge_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_merge_side_data(AVPacket* pkt);
		
		// Func<AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_split_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_split_side_data(AVPacket* pkt);
		
		// Func<AVDictionary*, int*, byte*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_pack_dictionary", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern byte* av_packet_pack_dictionary(AVDictionary* dict, int* size);
		
		// Func<byte*, int, AVDictionary**, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_unpack_dictionary", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_unpack_dictionary(byte* data, int size, AVDictionary** dict);
		
		// Action<AVPacket*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_free_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_packet_free_side_data(AVPacket* pkt);
		
		// Func<AVPacket*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_ref(AVPacket* dst, AVPacket* src);
		
		// Action<AVPacket*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_unref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_packet_unref(AVPacket* pkt);
		
		// Action<AVPacket*, AVPacket*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_move_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_packet_move_ref(AVPacket* dst, AVPacket* src);
		
		// Func<AVPacket*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_copy_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_packet_copy_props(AVPacket* dst, AVPacket* src);
		
		// Action<AVPacket*, AVRational, AVRational>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_packet_rescale_ts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_packet_rescale_ts(AVPacket* pkt, AVRational tb_src, AVRational tb_dst);
		
		// Func<AVCodecID, AVCodec*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_decoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_decoder(AVCodecID id);
		
		// Func<String, AVCodec*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_decoder_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_decoder_by_name(String name);
		
		// Func<AVCodecContext*, AVFrame*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_get_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_get_buffer(AVCodecContext* s, AVFrame* pic);
		
		// Action<AVCodecContext*, AVFrame*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_release_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_default_release_buffer(AVCodecContext* s, AVFrame* pic);
		
		// Func<AVCodecContext*, AVFrame*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_reget_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_reget_buffer(AVCodecContext* s, AVFrame* pic);
		
		// Func<AVCodecContext*, AVFrame*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_get_buffer2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_get_buffer2(AVCodecContext* s, AVFrame* frame, int flags);
		
		// Func<int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_edge_width", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_get_edge_width();
		
		// Action<AVCodecContext*, int*, int*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_align_dimensions", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_align_dimensions(AVCodecContext* s, int* width, int* height);
		
		// Action<AVCodecContext*, int*, int*, int*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_align_dimensions2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_align_dimensions2(AVCodecContext* s, int* width, int* height, int* linesize_align);
		
		// Func<int*, int*, AVChromaLocation, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_enum_to_chroma_pos", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_enum_to_chroma_pos(int* xpos, int* ypos, AVChromaLocation pos);
		
		// Func<int, int, AVChromaLocation>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_chroma_pos_to_enum", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVChromaLocation avcodec_chroma_pos_to_enum(int xpos, int ypos);
		
		// Func<AVCodecContext*, short*, int*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_audio3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_audio3(AVCodecContext* avctx, short* samples, int* frame_size_ptr, AVPacket* avpkt);
		
		// Func<AVCodecContext*, AVFrame*, int*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_audio4", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_audio4(AVCodecContext* avctx, AVFrame* frame, int* got_frame_ptr, AVPacket* avpkt);
		
		// Func<AVCodecContext*, AVFrame*, int*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_video2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_video2(AVCodecContext* avctx, AVFrame* picture, int* got_picture_ptr, AVPacket* avpkt);
		
		// Func<AVCodecContext*, AVSubtitle*, int*, AVPacket*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_decode_subtitle2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_decode_subtitle2(AVCodecContext* avctx, AVSubtitle* sub, int* got_sub_ptr, AVPacket* avpkt);
		
		// Func<AVCodecParser*, AVCodecParser*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecParser* av_parser_next(AVCodecParser* c);
		
		// Action<AVCodecParser*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_register_codec_parser", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_codec_parser(AVCodecParser* parser);
		
		// Func<int, AVCodecParserContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecParserContext* av_parser_init(int codec_id);
		
		// Func<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, long, long, long, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_parse2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parser_parse2(AVCodecParserContext* s, AVCodecContext* avctx, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size, long pts, long dts, long pos);
		
		// Func<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_change", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_parser_change(AVCodecParserContext* s, AVCodecContext* avctx, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size, int keyframe);
		
		// Action<AVCodecParserContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_parser_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_parser_close(AVCodecParserContext* s);
		
		// Func<AVCodecID, AVCodec*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_encoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_encoder(AVCodecID id);
		
		// Func<String, AVCodec*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_encoder_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* avcodec_find_encoder_by_name(String name);
		
		// Func<AVCodecContext*, byte*, int, short*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_audio(AVCodecContext* avctx, byte* buf, int buf_size, short* samples);
		
		// Func<AVCodecContext*, AVPacket*, AVFrame*, int*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_audio2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_audio2(AVCodecContext* avctx, AVPacket* avpkt, AVFrame* frame, int* got_packet_ptr);
		
		// Func<AVCodecContext*, byte*, int, AVFrame*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_video", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_video(AVCodecContext* avctx, byte* buf, int buf_size, AVFrame* pict);
		
		// Func<AVCodecContext*, AVPacket*, AVFrame*, int*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_video2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_video2(AVCodecContext* avctx, AVPacket* avpkt, AVFrame* frame, int* got_packet_ptr);
		
		// Func<AVCodecContext*, byte*, int, AVSubtitle*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_encode_subtitle", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_encode_subtitle(AVCodecContext* avctx, byte* buf, int buf_size, AVSubtitle* sub);
		
		// Func<int, int, int, int, AVSampleFormat, AVSampleFormat, int, int, int, double, ReSampleContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_audio_resample_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ReSampleContext* av_audio_resample_init(int output_channels, int input_channels, int output_rate, int input_rate, AVSampleFormat sample_fmt_out, AVSampleFormat sample_fmt_in, int filter_length, int log2_phase_count, int linear, double cutoff);
		
		// Func<ReSampleContext*, short*, short*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="audio_resample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int audio_resample(ReSampleContext* s, short* output, short* input, int nb_samples);
		
		// Action<ReSampleContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="audio_resample_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void audio_resample_close(ReSampleContext* s);
		
		// Func<int, int, int, int, int, double, AVResampleContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVResampleContext* av_resample_init(int out_rate, int in_rate, int filter_length, int log2_phase_count, int linear, double cutoff);
		
		// Func<AVResampleContext*, short*, short*, int*, int, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_resample(AVResampleContext* c, short* dst, short* src, int* consumed, int src_size, int dst_size, int update_ctx);
		
		// Action<AVResampleContext*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample_compensate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_resample_compensate(AVResampleContext* c, int sample_delta, int compensation_distance);
		
		// Action<AVResampleContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_resample_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_resample_close(AVResampleContext* c);
		
		// Func<AVPicture*, AVPixelFormat, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_alloc(AVPicture* picture, AVPixelFormat pix_fmt, int width, int height);
		
		// Action<AVPicture*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avpicture_free(AVPicture* picture);
		
		// Func<AVPicture*, byte*, AVPixelFormat, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_fill", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_fill(AVPicture* picture, byte* ptr, AVPixelFormat pix_fmt, int width, int height);
		
		// Func<AVPicture*, AVPixelFormat, int, int, sbyte*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_layout(AVPicture* src, AVPixelFormat pix_fmt, int width, int height, sbyte* dest, int dest_size);
		
		// Func<AVPixelFormat, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_get_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_get_size(AVPixelFormat pix_fmt, int width, int height);
		
		// Func<AVPicture*, AVPicture*, AVPixelFormat, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avpicture_deinterlace", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avpicture_deinterlace(AVPicture* dst, AVPicture* src, AVPixelFormat pix_fmt, int width, int height);
		
		// Action<AVPicture*, AVPicture*, AVPixelFormat, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_picture_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_picture_copy(AVPicture* dst, AVPicture* src, AVPixelFormat pix_fmt, int width, int height);
		
		// Func<AVPicture*, AVPicture*, AVPixelFormat, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_picture_crop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_picture_crop(AVPicture* dst, AVPicture* src, AVPixelFormat pix_fmt, int top_band, int left_band);
		
		// Func<AVPicture*, AVPicture*, int, int, AVPixelFormat, int, int, int, int, int*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_picture_pad", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_picture_pad(AVPicture* dst, AVPicture* src, int height, int width, AVPixelFormat pix_fmt, int padtop, int padbottom, int padleft, int padright, int* color);
		
		// Action<AVPixelFormat, int*, int*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_chroma_sub_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_get_chroma_sub_sample(AVPixelFormat pix_fmt, int* h_shift, int* v_shift);
		
		// Func<AVPixelFormat, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_pix_fmt_to_codec_tag", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_pix_fmt_to_codec_tag(AVPixelFormat pix_fmt);
		
		// Func<AVPixelFormat, AVPixelFormat, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_pix_fmt_loss", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_get_pix_fmt_loss(AVPixelFormat dst_pix_fmt, AVPixelFormat src_pix_fmt, int has_alpha);
		
		// Func<AVPixelFormat*, AVPixelFormat, int, int*, AVPixelFormat>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_best_pix_fmt_of_list", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* pix_fmt_list, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
		
		// Func<AVPixelFormat, AVPixelFormat, AVPixelFormat, int, int*, AVPixelFormat>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_best_pix_fmt_of_2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_2(AVPixelFormat dst_pix_fmt1, AVPixelFormat dst_pix_fmt2, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
		
		// Func<AVPixelFormat, AVPixelFormat, AVPixelFormat, int, int*, AVPixelFormat>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_find_best_pix_fmt2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_find_best_pix_fmt2(AVPixelFormat dst_pix_fmt1, AVPixelFormat dst_pix_fmt2, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
		
		// Func<AVCodecContext*, AVPixelFormat*, AVPixelFormat>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_get_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat avcodec_default_get_format(AVCodecContext* s, AVPixelFormat* fmt);
		
		// Action<AVCodecContext*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_set_dimensions", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_set_dimensions(AVCodecContext* s, int width, int height);
		
		// Func<String, uint, int, uint>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_codec_tag_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern uint av_get_codec_tag_string(sbyte* /*String*/ buf, uint buf_size, int codec_tag);
		
		// Action<String, int, AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_string(sbyte* /*String*/ buf, int buf_size, AVCodecContext* enc, int encode);
		
		// Func<AVCodec*, int, String>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_profile_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_profile_name(AVCodec* codec, int profile);
		
		// Func<AVCodecContext*, Func<AVCodecContext*, void*, int>, void*, int*, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_execute", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_execute(AVCodecContext* c, IntPtr func_c2_arg2_1, void* arg, int* ret, int count, int size);
		
		// Func<AVCodecContext*, Func<AVCodecContext*, void*, int, int, int>, void*, int*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_default_execute2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_default_execute2(AVCodecContext* c, IntPtr func_c2_arg2___1, void* arg, int* ret, int count);
		
		// Func<AVFrame*, int, AVSampleFormat, byte*, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_fill_audio_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_fill_audio_frame(AVFrame* frame, int nb_channels, AVSampleFormat sample_fmt, byte* buf, int buf_size, int align);
		
		// Action<AVCodecContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_flush_buffers", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avcodec_flush_buffers(AVCodecContext* avctx);
		
		// Func<AVCodecID, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_bits_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_bits_per_sample(AVCodecID codec_id);
		
		// Func<AVSampleFormat, int, AVCodecID>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_pcm_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecID av_get_pcm_codec(AVSampleFormat fmt, int be);
		
		// Func<AVCodecID, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_exact_bits_per_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_exact_bits_per_sample(AVCodecID codec_id);
		
		// Func<AVCodecContext*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_get_audio_frame_duration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_audio_frame_duration(AVCodecContext* avctx, int frame_bytes);
		
		// Action<AVBitStreamFilter*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_register_bitstream_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_bitstream_filter(AVBitStreamFilter* bsf);
		
		// Func<String, AVBitStreamFilterContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBitStreamFilterContext* av_bitstream_filter_init(String name);
		
		// Func<AVBitStreamFilterContext*, AVCodecContext*, String, byte**, int*, byte*, int, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_bitstream_filter_filter(AVBitStreamFilterContext* bsfc, AVCodecContext* avctx, String args, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size, int keyframe);
		
		// Action<AVBitStreamFilterContext*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_bitstream_filter_close(AVBitStreamFilterContext* bsf);
		
		// Func<AVBitStreamFilter*, AVBitStreamFilter*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_bitstream_filter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVBitStreamFilter* av_bitstream_filter_next(AVBitStreamFilter* f);
		
		// Action<void*, int*, uint>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_fast_padded_malloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fast_padded_malloc(void* ptr, int* size, uint min_size);
		
		// Action<void*, int*, uint>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_fast_padded_mallocz", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fast_padded_mallocz(void* ptr, int* size, uint min_size);
		
		// Func<sbyte*, int, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_xiphlacing", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_xiphlacing(sbyte* s, int v);
		
		// Action<void*, String, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_log_missing_feature", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_missing_feature(void* avc, String feature, int want_sample);
		
		// Action<void*, String>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_log_ask_for_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_log_ask_for_sample(void* avc, String msg);
		
		// Action<AVHWAccel*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_register_hwaccel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_hwaccel(AVHWAccel* hwaccel);
		
		// Func<AVHWAccel*, AVHWAccel*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_hwaccel_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVHWAccel* av_hwaccel_next(AVHWAccel* hwaccel);
		
		// Func<Func<void**, AVLockOp, int>, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_lockmgr_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_lockmgr_register(IntPtr func_mutex_op_0);
		
		// Func<AVCodecID, AVMediaType>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_type", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVMediaType avcodec_get_type(AVCodecID codec_id);
		
		// Func<AVCodecID, String>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_get_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avcodec_get_name(AVCodecID id);
		
		// Func<AVCodecContext*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_is_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avcodec_is_open(AVCodecContext* s);
		
		// Func<AVCodec*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_is_encoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_is_encoder(AVCodec* codec);
		
		// Func<AVCodec*, int>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="av_codec_is_decoder", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_is_decoder(AVCodec* codec);
		
		// Func<AVCodecID, AVCodecDescriptor*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_descriptor_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* avcodec_descriptor_get(AVCodecID id);
		
		// Func<AVCodecDescriptor*, AVCodecDescriptor*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_descriptor_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* prev);
		
		// Func<String, AVCodecDescriptor*>
		[DllImport(AVCODEC_LIBRARY, EntryPoint="avcodec_descriptor_get_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name(String name);
		
		// Func<void*, String, String, int, AVOption**, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_set_string3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_set_string3(void* obj, String name, String val, int alloc, AVOption** o_out);
		
		// Func<void*, String, double, AVOption*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_set_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOption* av_set_double(void* obj, String name, double n);
		
		// Func<void*, String, AVRational, AVOption*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_set_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOption* av_set_q(void* obj, String name, AVRational n);
		
		// Func<void*, String, long, AVOption*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_set_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOption* av_set_int(void* obj, String name, long n);
		
		// Func<void*, String, AVOption**, double>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern double av_get_double(void* obj, String name, AVOption** o_out);
		
		// Func<void*, String, AVOption**, AVRational>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_get_q(void* obj, String name, AVOption** o_out);
		
		// Func<void*, String, AVOption**, long>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_get_int(void* obj, String name, AVOption** o_out);
		
		// Func<void*, String, AVOption**, String, int, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_string(void* obj, sbyte* /*String*/ name, AVOption** o_out, sbyte* /*String*/ buf, int buf_len);
		
		// Func<void*, AVOption*, AVOption*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_next_option", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOption* av_next_option(void* obj, AVOption* last);
		
		// Func<void*, void*, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_show2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_show2(void* obj, void* av_log_obj, int req_flags, int rej_flags);
		
		// Action<void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_defaults", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_opt_set_defaults(void* s);
		
		// Action<void*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_defaults2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_opt_set_defaults2(void* s, int mask, int flags);
		
		// Func<void*, String, String, String, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_set_options_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_set_options_string(void* ctx, String opts, String key_val_sep, String pairs_sep);
		
		// Func<void*, String, sbyte**, String, String, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_from_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_from_string(void* ctx, String opts, sbyte** shorthand, String key_val_sep, String pairs_sep);
		
		// Action<void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_opt_free(void* obj);
		
		// Func<void*, String, String, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_flag_is_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_flag_is_set(void* obj, String field_name, String flag_name);
		
		// Func<void*, AVDictionary**, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_dict", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_dict(void* obj, AVDictionary** options);
		
		// Func<void*, AVDictionary**, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_dict2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_dict2(void* obj, AVDictionary** options, int search_flags);
		
		// Func<sbyte**, String, String, int, sbyte**, sbyte**, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_key_value", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_key_value(sbyte** ropts, String key_val_sep, String pairs_sep, int flags, sbyte** rkey, sbyte** rval);
		
		// Func<void*, AVOption*, String, int*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_eval_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_eval_flags(void* obj, AVOption* o, String val, int* flags_out);
		
		// Func<void*, AVOption*, String, int*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_eval_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_eval_int(void* obj, AVOption* o, String val, int* int_out);
		
		// Func<void*, AVOption*, String, long*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_eval_int64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_eval_int64(void* obj, AVOption* o, String val, long* int64_out);
		
		// Func<void*, AVOption*, String, float*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_eval_float", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_eval_float(void* obj, AVOption* o, String val, float* float_out);
		
		// Func<void*, AVOption*, String, double*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_eval_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_eval_double(void* obj, AVOption* o, String val, double* double_out);
		
		// Func<void*, AVOption*, String, AVRational*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_eval_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_eval_q(void* obj, AVOption* o, String val, AVRational* q_out);
		
		// Func<void*, String, String, int, int, AVOption*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_find", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOption* av_opt_find(void* obj, String name, String unit, int opt_flags, int search_flags);
		
		// Func<void*, String, String, int, int, void**, AVOption*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_find2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOption* av_opt_find2(void* obj, String name, String unit, int opt_flags, int search_flags, void** target_obj);
		
		// Func<void*, AVOption*, AVOption*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOption* av_opt_next(void* obj, AVOption* prev);
		
		// Func<void*, void*, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_child_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_opt_child_next(void* obj, void* prev);
		
		// Func<AVClass*, AVClass*, AVClass*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_child_class_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* av_opt_child_class_next(AVClass* parent, AVClass* prev);
		
		// Func<void*, String, String, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set(void* obj, String name, String val, int search_flags);
		
		// Func<void*, String, long, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_int(void* obj, String name, long val, int search_flags);
		
		// Func<void*, String, double, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_double(void* obj, String name, double val, int search_flags);
		
		// Func<void*, String, AVRational, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_q(void* obj, String name, AVRational val, int search_flags);
		
		// Func<void*, String, byte*, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_bin", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_bin(void* obj, String name, byte* val, int size, int search_flags);
		
		// Func<void*, String, int, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_image_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_image_size(void* obj, String name, int w, int h, int search_flags);
		
		// Func<void*, String, AVPixelFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_pixel_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_pixel_fmt(void* obj, String name, AVPixelFormat fmt, int search_flags);
		
		// Func<void*, String, AVSampleFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_sample_fmt(void* obj, String name, AVSampleFormat fmt, int search_flags);
		
		// Func<void*, String, AVRational, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_video_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_video_rate(void* obj, String name, AVRational val, int search_flags);
		
		// Func<void*, String, long, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_channel_layout(void* obj, String name, long ch_layout, int search_flags);
		
		// Func<void*, String, AVDictionary*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_set_dict_val", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_set_dict_val(void* obj, String name, AVDictionary* val, int search_flags);
		
		// Func<void*, String, int, byte**, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get(void* obj, String name, int search_flags, byte** out_val);
		
		// Func<void*, String, int, long*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_int", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_int(void* obj, String name, int search_flags, long* out_val);
		
		// Func<void*, String, int, double*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_double", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_double(void* obj, String name, int search_flags, double* out_val);
		
		// Func<void*, String, int, AVRational*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_q", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_q(void* obj, String name, int search_flags, AVRational* out_val);
		
		// Func<void*, String, int, int*, int*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_image_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_image_size(void* obj, String name, int search_flags, int* w_out, int* h_out);
		
		// Func<void*, String, int, AVPixelFormat*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_pixel_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_pixel_fmt(void* obj, String name, int search_flags, AVPixelFormat* out_fmt);
		
		// Func<void*, String, int, AVSampleFormat*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_sample_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_sample_fmt(void* obj, String name, int search_flags, AVSampleFormat* out_fmt);
		
		// Func<void*, String, int, AVRational*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_video_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_video_rate(void* obj, String name, int search_flags, AVRational* out_val);
		
		// Func<void*, String, int, long*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_channel_layout", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_channel_layout(void* obj, String name, int search_flags, long* ch_layout);
		
		// Func<void*, String, int, AVDictionary**, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_get_dict_val", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_get_dict_val(void* obj, String name, int search_flags, AVDictionary** out_val);
		
		// Func<AVClass*, void*, String, void*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_ptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_opt_ptr(AVClass* avclass, void* obj, String name);
		
		// Action<AVOptionRanges**>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_freep_ranges", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_opt_freep_ranges(AVOptionRanges** ranges);
		
		// Func<AVOptionRanges**, void*, String, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_query_ranges", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_query_ranges(AVOptionRanges** p0, void* obj, String key, int flags);
		
		// Func<void*, void*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_copy(void* dest, void* src);
		
		// Func<AVOptionRanges**, void*, String, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_query_ranges_default", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_query_ranges_default(AVOptionRanges** p0, void* obj, String key, int flags);
		
		// Func<void*, AVOption*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_is_set_to_default", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_is_set_to_default(void* obj, AVOption* o);
		
		// Func<void*, String, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_is_set_to_default_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_is_set_to_default_by_name(void* obj, String name, int search_flags);
		
		// Func<void*, int, int, sbyte**, sbyte, sbyte, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_opt_serialize", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_opt_serialize(void* obj, int opt_flags, int flags, sbyte** buffer, sbyte key_val_sep, sbyte pairs_sep);
		
		// Func<String, String>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_find_protocol_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avio_find_protocol_name(String url);
		
		// Func<String, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_check", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_check(String url, int flags);
		
		// Func<sbyte*, int, int, void*, Func<void*, byte*, int, int>, Func<void*, byte*, int, int>, Func<void*, long, int, long>, AVIOContext*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVIOContext* avio_alloc_context(sbyte* buffer, int buffer_size, int write_flag, void* opaque, IntPtr func_opaque_buf_buf_size_4, IntPtr func_opaque_buf_buf_size_5, IntPtr func_opaque_offset_whence_6);
		
		// Action<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_w8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_w8(AVIOContext* s, int b);
		
		// Action<AVIOContext*, sbyte*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_write", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_write(AVIOContext* s, sbyte* buf, int size);
		
		// Action<AVIOContext*, ulong>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl64(AVIOContext* s, ulong val);
		
		// Action<AVIOContext*, ulong>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb64(AVIOContext* s, ulong val);
		
		// Action<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl32(AVIOContext* s, int val);
		
		// Action<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb32(AVIOContext* s, int val);
		
		// Action<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl24(AVIOContext* s, int val);
		
		// Action<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb24(AVIOContext* s, int val);
		
		// Action<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wl16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wl16(AVIOContext* s, int val);
		
		// Action<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_wb16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_wb16(AVIOContext* s, int val);
		
		// Func<AVIOContext*, String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_put_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_put_str(AVIOContext* s, String str);
		
		// Func<AVIOContext*, String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_put_str16le", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_put_str16le(AVIOContext* s, String str);
		
		// Func<AVIOContext*, long, int, long>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_seek", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_seek(AVIOContext* s, long offset, int whence);
		
		// Func<AVIOContext*, long, long>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_skip", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_skip(AVIOContext* s, long offset);
		
		// Func<AVIOContext*, long>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_size(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_feof", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_feof(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="url_feof", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int url_feof(AVIOContext* s);
		
		// Func<AVIOContext*, String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_printf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_printf(AVIOContext* s, String fmt);
		
		// Action<AVIOContext*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_flush", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avio_flush(AVIOContext* s);
		
		// Func<AVIOContext*, sbyte*, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_read(AVIOContext* s, sbyte* buf, int size);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_r8", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_r8(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rl16(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rl24(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rl32(AVIOContext* s);
		
		// Func<AVIOContext*, ulong>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rl64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong avio_rl64(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb16", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rb16(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rb24(AVIOContext* s);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_rb32(AVIOContext* s);
		
		// Func<AVIOContext*, ulong>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_rb64", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern ulong avio_rb64(AVIOContext* s);
		
		// Func<AVIOContext*, int, String, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_get_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_get_str(AVIOContext* pb, int maxlen, sbyte* /*String*/ buf, int buflen);
		
		// Func<AVIOContext*, int, String, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_get_str16le", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_get_str16le(AVIOContext* pb, int maxlen, sbyte* /*String*/ buf, int buflen);
		
		// Func<AVIOContext*, int, String, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_get_str16be", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_get_str16be(AVIOContext* pb, int maxlen, sbyte* /*String*/ buf, int buflen);
		
		// Func<AVIOContext**, String, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_open(AVIOContext** s, String url, int flags);
		
		// Func<AVIOContext**, String, int, AVIOInterruptCB*, AVDictionary**, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_open2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_open2(AVIOContext** s, String url, int flags, AVIOInterruptCB* int_cb, AVDictionary** options);
		
		// Func<AVIOContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_close(AVIOContext* s);
		
		// Func<AVIOContext**, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_closep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_closep(AVIOContext** s);
		
		// Func<AVIOContext**, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_open_dyn_buf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_open_dyn_buf(AVIOContext** s);
		
		// Func<AVIOContext*, byte**, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_close_dyn_buf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_close_dyn_buf(AVIOContext* s, byte** pbuffer);
		
		// Func<void**, int, String>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_enum_protocols", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avio_enum_protocols(void** opaque, int output);
		
		// Func<AVIOContext*, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_pause", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_pause(AVIOContext* h, int pause);
		
		// Func<AVIOContext*, int, long, int, long>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_seek_time", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long avio_seek_time(AVIOContext* h, int stream_index, long timestamp, int flags);
		
		// Func<AVIOContext*, AVBPrint*, uint, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avio_read_to_bprint", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avio_read_to_bprint(AVIOContext* h, AVBPrint* pb, uint max_size);
		
		// Func<AVIOContext*, AVPacket*, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_get_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_packet(AVIOContext* s, AVPacket* pkt, int size);
		
		// Func<AVIOContext*, AVPacket*, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_append_packet", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_append_packet(AVIOContext* s, AVPacket* pkt, int size);
		
		// Func<AVStream*, AVRational>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_get_r_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_stream_get_r_frame_rate(AVStream* s);
		
		// Action<AVStream*, AVRational>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_set_r_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_stream_set_r_frame_rate(AVStream* s, AVRational r);
		
		// Func<AVStream*, AVCodecParserContext*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_get_parser", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecParserContext* av_stream_get_parser(AVStream* s);
		
		// Func<AVStream*, String>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_get_recommended_encoder_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_stream_get_recommended_encoder_configuration(AVStream* s);
		
		// Action<AVStream*, String>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_set_recommended_encoder_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_stream_set_recommended_encoder_configuration(AVStream* s, String configuration);
		
		// Func<AVStream*, long>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_get_end_pts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long av_stream_get_end_pts(AVStream* st);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_get_probe_score", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_format_get_probe_score(AVFormatContext* s);
		
		// Func<AVFormatContext*, AVCodec*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_get_video_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* av_format_get_video_codec(AVFormatContext* s);
		
		// Action<AVFormatContext*, AVCodec*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_set_video_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_format_set_video_codec(AVFormatContext* s, AVCodec* c);
		
		// Func<AVFormatContext*, AVCodec*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_get_audio_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* av_format_get_audio_codec(AVFormatContext* s);
		
		// Action<AVFormatContext*, AVCodec*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_set_audio_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_format_set_audio_codec(AVFormatContext* s, AVCodec* c);
		
		// Func<AVFormatContext*, AVCodec*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_get_subtitle_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodec* av_format_get_subtitle_codec(AVFormatContext* s);
		
		// Action<AVFormatContext*, AVCodec*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_set_subtitle_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_format_set_subtitle_codec(AVFormatContext* s, AVCodec* c);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_get_metadata_header_padding", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_format_get_metadata_header_padding(AVFormatContext* s);
		
		// Action<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_set_metadata_header_padding", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_format_set_metadata_header_padding(AVFormatContext* s, int c);
		
		// Func<AVFormatContext*, void*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_get_opaque", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void* av_format_get_opaque(AVFormatContext* s);
		
		// Action<AVFormatContext*, void*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_set_opaque", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_format_set_opaque(AVFormatContext* s, void* opaque);
		
		// Func<AVFormatContext*, av_format_control_message>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_get_control_message_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern av_format_control_message av_format_get_control_message_cb(AVFormatContext* s);
		
		// Action<AVFormatContext*, av_format_control_message>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_set_control_message_cb", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_format_set_control_message_cb(AVFormatContext* s, av_format_control_message callback);
		
		// Action<AVFormatContext*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_format_inject_global_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_format_inject_global_side_data(AVFormatContext* s);
		
		// Func<AVFormatContext*, AVDurationEstimationMethod>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_fmt_ctx_get_duration_estimation_method", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* ctx);
		
		// Func<int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_version();
		
		// Func<String>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avformat_configuration();
		
		// Func<String>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avformat_license();
		
		// Action
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_all();
		
		// Action<AVInputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_register_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_input_format(AVInputFormat* format);
		
		// Action<AVOutputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_register_output_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_register_output_format(AVOutputFormat* format);
		
		// Func<int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_network_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_network_init();
		
		// Func<int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_network_deinit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_network_deinit();
		
		// Func<AVInputFormat*, AVInputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_iformat_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_iformat_next(AVInputFormat* f);
		
		// Func<AVOutputFormat*, AVOutputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_oformat_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOutputFormat* av_oformat_next(AVOutputFormat* f);
		
		// Func<AVFormatContext*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFormatContext* avformat_alloc_context();
		
		// Action<AVFormatContext*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avformat_free_context(AVFormatContext* s);
		
		// Func<AVClass*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avformat_get_class();
		
		// Func<AVFormatContext*, AVCodec*, AVStream*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_new_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVStream* avformat_new_stream(AVFormatContext* s, AVCodec* c);
		
		// Func<AVStream*, AVPacketSideDataType, int*, byte*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_stream_get_side_data", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern byte* av_stream_get_side_data(AVStream* stream, AVPacketSideDataType type, int* size);
		
		// Func<AVFormatContext*, int, AVProgram*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_new_program", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVProgram* av_new_program(AVFormatContext* s, int id);
		
		// Func<AVFormatContext**, AVOutputFormat*, String, String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_alloc_output_context2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_alloc_output_context2(AVFormatContext** ctx, AVOutputFormat* oformat, String format_name, String filename);
		
		// Func<String, AVInputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_find_input_format(String short_name);
		
		// Func<AVProbeData*, int, AVInputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_probe_input_format(AVProbeData* pd, int is_opened);
		
		// Func<AVProbeData*, int, int*, AVInputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_format2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_probe_input_format2(AVProbeData* pd, int is_opened, int* score_max);
		
		// Func<AVProbeData*, int, int*, AVInputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_format3", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_probe_input_format3(AVProbeData* pd, int is_opened, int* score_ret);
		
		// Func<AVIOContext*, AVInputFormat**, String, void*, int, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_buffer2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_probe_input_buffer2(AVIOContext* pb, AVInputFormat** fmt, String filename, void* logctx, int offset, int max_probe_size);
		
		// Func<AVIOContext*, AVInputFormat**, String, void*, int, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_probe_input_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_probe_input_buffer(AVIOContext* pb, AVInputFormat** fmt, String filename, void* logctx, int offset, int max_probe_size);
		
		// Func<AVFormatContext**, String, AVInputFormat*, AVDictionary**, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_open_input", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_open_input(AVFormatContext** ps, String filename, AVInputFormat* fmt, AVDictionary** options);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_demuxer_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_demuxer_open(AVFormatContext* ic);
		
		// Func<AVFormatContext*, AVDictionary**, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_find_stream_info", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_find_stream_info(AVFormatContext* ic, AVDictionary** options);
		
		// Func<AVFormatContext*, AVProgram*, int, AVProgram*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_program_from_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVProgram* av_find_program_from_stream(AVFormatContext* ic, AVProgram* last, int s);
		
		// Func<AVFormatContext*, AVMediaType, int, int, AVCodec**, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_best_stream", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_find_best_stream(AVFormatContext* ic, AVMediaType type, int wanted_stream_nb, int related_stream, AVCodec** decoder_ret, int flags);
		
		// Func<AVFormatContext*, AVPacket*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_read_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_read_frame(AVFormatContext* s, AVPacket* pkt);
		
		// Func<AVFormatContext*, int, long, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_seek_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_seek_frame(AVFormatContext* s, int stream_index, long timestamp, int flags);
		
		// Func<AVFormatContext*, int, long, long, long, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_seek_file", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_seek_file(AVFormatContext* s, int stream_index, long min_ts, long ts, long max_ts, int flags);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_read_play", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_read_play(AVFormatContext* s);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_read_pause", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_read_pause(AVFormatContext* s);
		
		// Action<AVFormatContext**>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_close_input", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avformat_close_input(AVFormatContext** s);
		
		// Func<AVFormatContext*, AVDictionary**, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_write_header", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_write_header(AVFormatContext* s, AVDictionary** options);
		
		// Func<AVFormatContext*, AVPacket*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_write_frame(AVFormatContext* s, AVPacket* pkt);
		
		// Func<AVFormatContext*, AVPacket*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_interleaved_write_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_interleaved_write_frame(AVFormatContext* s, AVPacket* pkt);
		
		// Func<AVFormatContext*, int, AVFrame*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_write_uncoded_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_write_uncoded_frame(AVFormatContext* s, int stream_index, AVFrame* frame);
		
		// Func<AVFormatContext*, int, AVFrame*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_interleaved_write_uncoded_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_interleaved_write_uncoded_frame(AVFormatContext* s, int stream_index, AVFrame* frame);
		
		// Func<AVFormatContext*, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_write_uncoded_frame_query", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_write_uncoded_frame_query(AVFormatContext* s, int stream_index);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_write_trailer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_write_trailer(AVFormatContext* s);
		
		// Func<String, String, String, AVOutputFormat*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOutputFormat* av_guess_format(String short_name, String filename, String mime_type);
		
		// Func<AVOutputFormat*, String, String, String, AVMediaType, AVCodecID>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecID av_guess_codec(AVOutputFormat* fmt, String short_name, String filename, String mime_type, AVMediaType type);
		
		// Func<AVFormatContext*, int, long*, long*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_get_output_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_output_timestamp(AVFormatContext* s, int stream, long* dts, long* wall);
		
		// Action<void*, byte*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_hex_dump", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_hex_dump(void* f, byte* buf, int size);
		
		// Action<void*, int, byte*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_hex_dump_log", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_hex_dump_log(void* avcl, int level, byte* buf, int size);
		
		// Action<void*, AVPacket*, int, AVStream*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_pkt_dump2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_pkt_dump2(void* f, AVPacket* pkt, int dump_payload, AVStream* st);
		
		// Action<void*, int, AVPacket*, int, AVStream*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_pkt_dump_log2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_pkt_dump_log2(void* avcl, int level, AVPacket* pkt, int dump_payload, AVStream* st);
		
		// Func<AVCodecTag**, int, AVCodecID>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_codec_get_id", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecID av_codec_get_id(AVCodecTag** tags, int tag);
		
		// Func<AVCodecTag**, AVCodecID, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_codec_get_tag", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_tag(AVCodecTag** tags, AVCodecID id);
		
		// Func<AVCodecTag**, AVCodecID, int*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_codec_get_tag2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_codec_get_tag2(AVCodecTag** tags, AVCodecID id, int* tag);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_find_default_stream_index", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_find_default_stream_index(AVFormatContext* s);
		
		// Func<AVStream*, long, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_index_search_timestamp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_index_search_timestamp(AVStream* st, long timestamp, int flags);
		
		// Func<AVStream*, long, long, int, int, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_add_index_entry", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_add_index_entry(AVStream* st, long pos, long timestamp, int size, int distance, int flags);
		
		// Action<String, int, String, int, String, int, int*, String, int, String>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_url_split", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_url_split(sbyte* /*String*/ proto, int proto_size, sbyte* /*String*/ authorization, int authorization_size, sbyte* /*String*/ hostname, int hostname_size, int* port_ptr, sbyte* /*String*/ path, int path_size, sbyte* /*String*/ url);
		
		// Action<AVFormatContext*, int, String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_dump_format", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_dump_format(AVFormatContext* ic, int index, String url, int is_output);
		
		// Func<String, int, String, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_get_frame_filename", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_frame_filename(sbyte* /*String*/ buf, int buf_size, sbyte* /*String*/ path, int number);
		
		// Func<String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_filename_number_test", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_filename_number_test(String filename);
		
		// Func<AVFormatContext**, int, String, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_sdp_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_sdp_create(AVFormatContext** ac, int n_files, sbyte* /*String*/ buf, int size);
		
		// Func<String, String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_match_ext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_match_ext(String filename, String extensions);
		
		// Func<AVOutputFormat*, AVCodecID, int, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_query_codec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_query_codec(AVOutputFormat* ofmt, AVCodecID codec_id, int std_compliance);
		
		// Func<AVCodecTag*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_riff_video_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecTag* avformat_get_riff_video_tags();
		
		// Func<AVCodecTag*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_riff_audio_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecTag* avformat_get_riff_audio_tags();
		
		// Func<AVCodecTag*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_mov_video_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecTag* avformat_get_mov_video_tags();
		
		// Func<AVCodecTag*>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_get_mov_audio_tags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVCodecTag* avformat_get_mov_audio_tags();
		
		// Func<AVFormatContext*, AVStream*, AVFrame*, AVRational>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_sample_aspect_ratio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_guess_sample_aspect_ratio(AVFormatContext* format, AVStream* stream, AVFrame* frame);
		
		// Func<AVFormatContext*, AVStream*, AVFrame*, AVRational>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="av_guess_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_guess_frame_rate(AVFormatContext* ctx, AVStream* stream, AVFrame* frame);
		
		// Func<AVFormatContext*, AVStream*, String, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_match_stream_specifier", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_match_stream_specifier(AVFormatContext* s, AVStream* st, String spec);
		
		// Func<AVFormatContext*, int>
		[DllImport(AVFORMAT_LIBRARY, EntryPoint="avformat_queue_attached_pictures", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avformat_queue_attached_pictures(AVFormatContext* s);
		
		// Func<int>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avdevice_version();
		
		// Func<String>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avdevice_configuration();
		
		// Func<String>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avdevice_license();
		
		// Action
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avdevice_register_all();
		
		// Func<AVInputFormat*, AVInputFormat*>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="av_input_audio_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_input_audio_device_next(AVInputFormat* d);
		
		// Func<AVInputFormat*, AVInputFormat*>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="av_input_video_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVInputFormat* av_input_video_device_next(AVInputFormat* d);
		
		// Func<AVOutputFormat*, AVOutputFormat*>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="av_output_audio_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOutputFormat* av_output_audio_device_next(AVOutputFormat* d);
		
		// Func<AVOutputFormat*, AVOutputFormat*>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="av_output_video_device_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVOutputFormat* av_output_video_device_next(AVOutputFormat* d);
		
		// Func<AVFormatContext*, AVAppToDevMessageType, void*, uint, int>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_app_to_dev_control_message", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avdevice_app_to_dev_control_message(AVFormatContext* s, AVAppToDevMessageType type, void* data, uint data_size);
		
		// Func<AVFormatContext*, AVDevToAppMessageType, void*, uint, int>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_dev_to_app_control_message", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avdevice_dev_to_app_control_message(AVFormatContext* s, AVDevToAppMessageType type, void* data, uint data_size);
		
		// Func<AVDeviceCapabilitiesQuery**, AVFormatContext*, AVDictionary**, int>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_capabilities_create", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avdevice_capabilities_create(AVDeviceCapabilitiesQuery** caps, AVFormatContext* s, AVDictionary** device_options);
		
		// Action<AVDeviceCapabilitiesQuery**, AVFormatContext*>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_capabilities_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avdevice_capabilities_free(AVDeviceCapabilitiesQuery** caps, AVFormatContext* s);
		
		// Func<AVFormatContext*, AVDeviceInfoList**, int>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_list_devices", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avdevice_list_devices(AVFormatContext* s, AVDeviceInfoList** device_list);
		
		// Action<AVDeviceInfoList**>
		[DllImport(AVDEVICE_LIBRARY, EntryPoint="avdevice_free_list_devices", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avdevice_free_list_devices(AVDeviceInfoList** device_list);
		
		// Func<int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_version();
		
		// Func<String>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_configuration();
		
		// Func<String>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_license();
		
		// Action<AVFilterBufferRef*, AVFilterBufferRef*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_copy_buffer_ref_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_copy_buffer_ref_props(AVFilterBufferRef* dst, AVFilterBufferRef* src);
		
		// Func<AVFilterBufferRef*, int, AVFilterBufferRef*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_ref_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_ref_buffer(AVFilterBufferRef* @ref, int pmask);
		
		// Action<AVFilterBufferRef*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_unref_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_unref_buffer(AVFilterBufferRef* @ref);
		
		// Action<AVFilterBufferRef**>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_unref_bufferp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_unref_bufferp(AVFilterBufferRef** @ref);
		
		// Func<AVFilterBufferRef*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_ref_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_ref_get_channels(AVFilterBufferRef* @ref);
		
		// Func<AVFilterPad*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_pad_count", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_pad_count(AVFilterPad* pads);
		
		// Func<AVFilterPad*, int, String>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_pad_get_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_pad_get_name(AVFilterPad* pads, int pad_idx);
		
		// Func<AVFilterPad*, int, AVMediaType>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_pad_get_type", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVMediaType avfilter_pad_get_type(AVFilterPad* pads, int pad_idx);
		
		// Func<AVFilterContext*, int, AVFilterContext*, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_link(AVFilterContext* src, int srcpad, AVFilterContext* dst, int dstpad);
		
		// Action<AVFilterLink**>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_link_free(AVFilterLink** link);
		
		// Func<AVFilterLink*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link_get_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_link_get_channels(AVFilterLink* link);
		
		// Action<AVFilterLink*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_link_set_closed", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_link_set_closed(AVFilterLink* link, int closed);
		
		// Func<AVFilterContext*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_config_links", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_config_links(AVFilterContext* filter);
		
		// Func<byte**, int*, int, int, int, AVPixelFormat, AVFilterBufferRef*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_video_buffer_ref_from_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_get_video_buffer_ref_from_arrays(byte** data, int* linesize, int perms, int w, int h, AVPixelFormat format);
		
		// Func<byte**, int, int, int, AVSampleFormat, ulong, AVFilterBufferRef*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_audio_buffer_ref_from_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_get_audio_buffer_ref_from_arrays(byte** data, int linesize, int perms, int nb_samples, AVSampleFormat sample_fmt, ulong channel_layout);
		
		// Func<byte**, int, int, int, AVSampleFormat, int, ulong, AVFilterBufferRef*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_audio_buffer_ref_from_arrays_channels", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterBufferRef* avfilter_get_audio_buffer_ref_from_arrays_channels(byte** data, int linesize, int perms, int nb_samples, AVSampleFormat sample_fmt, int channels, ulong channel_layout);
		
		// Func<AVFilterContext*, String, String, String, int, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_process_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_process_command(AVFilterContext* filter, sbyte* /*String*/ cmd, sbyte* /*String*/ arg, sbyte* /*String*/ res, int res_len, int flags);
		
		// Action
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_register_all", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_register_all();
		
		// Action
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_uninit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_uninit();
		
		// Func<AVFilter*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_register(AVFilter* filter);
		
		// Func<String, AVFilter*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_by_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilter* avfilter_get_by_name(String name);
		
		// Func<AVFilter*, AVFilter*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilter* avfilter_next(AVFilter* prev);
		
		// Func<AVFilter**, AVFilter**>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_filter_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilter** av_filter_next(AVFilter** filter);
		
		// Func<AVFilterContext**, AVFilter*, String, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_open", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_open(AVFilterContext** filter_ctx, AVFilter* filter, String inst_name);
		
		// Func<AVFilterContext*, String, void*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_init_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_init_filter(AVFilterContext* filter, String args, void* opaque);
		
		// Func<AVFilterContext*, String, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_init_str", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_init_str(AVFilterContext* ctx, String args);
		
		// Func<AVFilterContext*, AVDictionary**, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_init_dict", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_init_dict(AVFilterContext* ctx, AVDictionary** options);
		
		// Action<AVFilterContext*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_free(AVFilterContext* filter);
		
		// Func<AVFilterLink*, AVFilterContext*, int, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_insert_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_insert_filter(AVFilterLink* link, AVFilterContext* filt, int filt_srcpad_idx, int filt_dstpad_idx);
		
		// Func<AVFilterBufferRef*, AVFrame*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_copy_frame_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_copy_frame_props(AVFilterBufferRef* dst, AVFrame* src);
		
		// Func<AVFrame*, AVFilterBufferRef*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_copy_buf_props", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_copy_buf_props(AVFrame* dst, AVFilterBufferRef* src);
		
		// Func<AVClass*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* avfilter_get_class();
		
		// Func<AVFilterGraph*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterGraph* avfilter_graph_alloc();
		
		// Func<AVFilterGraph*, AVFilter*, String, AVFilterContext*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_alloc_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* graph, AVFilter* filter, String name);
		
		// Func<AVFilterGraph*, String, AVFilterContext*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_get_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* graph, String name);
		
		// Func<AVFilterGraph*, AVFilterContext*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_add_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_add_filter(AVFilterGraph* graphctx, AVFilterContext* filter);
		
		// Func<AVFilterContext**, AVFilter*, String, String, void*, AVFilterGraph*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_create_filter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_create_filter(AVFilterContext** filt_ctx, AVFilter* filt, String name, String args, void* opaque, AVFilterGraph* graph_ctx);
		
		// Action<AVFilterGraph*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_set_auto_convert", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_graph_set_auto_convert(AVFilterGraph* graph, int flags);
		
		// Func<AVFilterGraph*, void*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_config", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_config(AVFilterGraph* graphctx, void* log_ctx);
		
		// Action<AVFilterGraph**>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_graph_free(AVFilterGraph** graph);
		
		// Func<AVFilterInOut*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_inout_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFilterInOut* avfilter_inout_alloc();
		
		// Action<AVFilterInOut**>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_inout_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void avfilter_inout_free(AVFilterInOut** inout);
		
		// Func<AVFilterGraph*, String, AVFilterInOut*, AVFilterInOut*, void*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_parse", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_parse(AVFilterGraph* graph, String filters, AVFilterInOut* inputs, AVFilterInOut* outputs, void* log_ctx);
		
		// Func<AVFilterGraph*, String, AVFilterInOut**, AVFilterInOut**, void*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_parse_ptr", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_parse_ptr(AVFilterGraph* graph, String filters, AVFilterInOut** inputs, AVFilterInOut** outputs, void* log_ctx);
		
		// Func<AVFilterGraph*, String, AVFilterInOut**, AVFilterInOut**, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_parse2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_parse2(AVFilterGraph* graph, String filters, AVFilterInOut** inputs, AVFilterInOut** outputs);
		
		// Func<AVFilterGraph*, String, String, String, String, int, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_send_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_send_command(AVFilterGraph* graph, String target, String cmd, String arg, String res, int res_len, int flags);
		
		// Func<AVFilterGraph*, String, String, String, int, double, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_queue_command", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_queue_command(AVFilterGraph* graph, String target, String cmd, String arg, int flags, double ts);
		
		// Func<AVFilterGraph*, String, String>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_dump", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String avfilter_graph_dump(AVFilterGraph* graph, String options);
		
		// Func<AVFilterGraph*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="avfilter_graph_request_oldest", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int avfilter_graph_request_oldest(AVFilterGraph* graph);
		
		// Func<AVFilterContext*, AVFilterBufferRef**, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_get_buffer_ref", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffersink_get_buffer_ref(AVFilterContext* buffer_sink, AVFilterBufferRef** bufref, int flags);
		
		// Func<AVFilterContext*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_poll_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffersink_poll_frame(AVFilterContext* ctx);
		
		// Func<AVFilterContext*, AVFilterBufferRef**, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffersink_read(AVFilterContext* ctx, AVFilterBufferRef** buf);
		
		// Func<AVFilterContext*, AVFilterBufferRef**, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_read_samples", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffersink_read_samples(AVFilterContext* ctx, AVFilterBufferRef** buf, int nb_samples);
		
		// Func<AVFilterContext*, AVFrame*, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_get_frame_flags", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffersink_get_frame_flags(AVFilterContext* ctx, AVFrame* frame, int flags);
		
		// Func<AVBufferSinkParams*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_params_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern Anon11* av_buffersink_params_alloc();
		
		// Func<AVABufferSinkParams*>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_abuffersink_params_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern Anon12* av_abuffersink_params_alloc();
		
		// Action<AVFilterContext*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_set_frame_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_buffersink_set_frame_size(AVFilterContext* ctx, int frame_size);
		
		// Func<AVFilterContext*, AVRational>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_get_frame_rate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVRational av_buffersink_get_frame_rate(AVFilterContext* ctx);
		
		// Func<AVFilterContext*, AVFrame*, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_get_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffersink_get_frame(AVFilterContext* ctx, AVFrame* frame);
		
		// Func<AVFilterContext*, AVFrame*, int, int>
		[DllImport(AVFILTER_LIBRARY, EntryPoint="av_buffersink_get_samples", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_buffersink_get_samples(AVFilterContext* ctx, AVFrame* frame, int nb_samples);
		
		// Func<int, AVFifoBuffer*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFifoBuffer* av_fifo_alloc(int size);
		
		// Func<uint, uint, AVFifoBuffer*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_alloc_array", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVFifoBuffer* av_fifo_alloc_array(uint nmemb, uint size);
		
		// Action<AVFifoBuffer*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fifo_free(AVFifoBuffer* f);
		
		// Action<AVFifoBuffer**>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_freep", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fifo_freep(AVFifoBuffer** f);
		
		// Action<AVFifoBuffer*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_reset", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fifo_reset(AVFifoBuffer* f);
		
		// Func<AVFifoBuffer*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_fifo_size(AVFifoBuffer* f);
		
		// Func<AVFifoBuffer*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_space", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_fifo_space(AVFifoBuffer* f);
		
		// Func<AVFifoBuffer*, void*, int, Action<void*, void*, int>, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_generic_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_fifo_generic_read(AVFifoBuffer* f, void* dest, int buf_size, IntPtr func____3);
		
		// Func<AVFifoBuffer*, void*, int, Func<void*, void*, int, int>, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_generic_write", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_fifo_generic_write(AVFifoBuffer* f, void* src, int size, IntPtr func____3);
		
		// Func<AVFifoBuffer*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_realloc2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_fifo_realloc2(AVFifoBuffer* f, int size);
		
		// Func<AVFifoBuffer*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_grow", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_fifo_grow(AVFifoBuffer* f, int additional_space);
		
		// Action<AVFifoBuffer*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_fifo_drain", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_fifo_drain(AVFifoBuffer* f, int size);
		
		// Action<AVAudioFifo*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_audio_fifo_free(AVAudioFifo* af);
		
		// Func<AVSampleFormat, int, int, AVAudioFifo*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat sample_fmt, int channels, int nb_samples);
		
		// Func<AVAudioFifo*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_realloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_audio_fifo_realloc(AVAudioFifo* af, int nb_samples);
		
		// Func<AVAudioFifo*, void**, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_write", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_audio_fifo_write(AVAudioFifo* af, void** data, int nb_samples);
		
		// Func<AVAudioFifo*, void**, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_read", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_audio_fifo_read(AVAudioFifo* af, void** data, int nb_samples);
		
		// Func<AVAudioFifo*, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_drain", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_audio_fifo_drain(AVAudioFifo* af, int nb_samples);
		
		// Action<AVAudioFifo*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_reset", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_audio_fifo_reset(AVAudioFifo* af);
		
		// Func<AVAudioFifo*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_audio_fifo_size(AVAudioFifo* af);
		
		// Func<AVAudioFifo*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_audio_fifo_space", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_audio_fifo_space(AVAudioFifo* af);
		
		// Action<ushort*, byte**, int*, AVPixFmtDescriptor*, int, int, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_read_image_line", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_read_image_line(ushort* dst, byte** data, int* linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w, int read_pal_component);
		
		// Action<ushort*, byte**, int*, AVPixFmtDescriptor*, int, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_write_image_line", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_write_image_line(ushort* src, byte** data, int* linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w);
		
		// Func<String, AVPixelFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_pix_fmt", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat av_get_pix_fmt(String name);
		
		// Func<AVPixelFormat, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_pix_fmt_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_pix_fmt_name(AVPixelFormat pix_fmt);
		
		// Func<String, int, AVPixelFormat, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_pix_fmt_string", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_get_pix_fmt_string(String buf, int buf_size, AVPixelFormat pix_fmt);
		
		// Func<AVPixFmtDescriptor*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_bits_per_pixel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_bits_per_pixel(AVPixFmtDescriptor* pixdesc);
		
		// Func<AVPixFmtDescriptor*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_padded_bits_per_pixel", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* pixdesc);
		
		// Func<AVPixelFormat, AVPixFmtDescriptor*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_pix_fmt_desc_get", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat pix_fmt);
		
		// Func<AVPixFmtDescriptor*, AVPixFmtDescriptor*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_pix_fmt_desc_next", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* prev);
		
		// Func<AVPixFmtDescriptor*, AVPixelFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_pix_fmt_desc_get_id", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* desc);
		
		// Func<AVPixelFormat, int*, int*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_pix_fmt_get_chroma_sub_sample", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat pix_fmt, int* h_shift, int* v_shift);
		
		// Func<AVPixelFormat, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_pix_fmt_count_planes", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_pix_fmt_count_planes(AVPixelFormat pix_fmt);
		
		// Func<AVPixelFormat, AVPixelFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_pix_fmt_swap_endianness", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat pix_fmt);
		
		// Func<AVPixelFormat, AVPixelFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_get_pix_fmt_loss", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_get_pix_fmt_loss(AVPixelFormat dst_pix_fmt, AVPixelFormat src_pix_fmt, int has_alpha);
		
		// Func<AVPixelFormat, AVPixelFormat, AVPixelFormat, int, int*, AVPixelFormat>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_find_best_pix_fmt_of_2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat dst_pix_fmt1, AVPixelFormat dst_pix_fmt2, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
		
		// Func<AVColorRange, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_color_range_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_color_range_name(AVColorRange range);
		
		// Func<AVColorPrimaries, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_color_primaries_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_color_primaries_name(AVColorPrimaries primaries);
		
		// Func<AVColorTransferCharacteristic, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_color_transfer_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_color_transfer_name(AVColorTransferCharacteristic transfer);
		
		// Func<AVColorSpace, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_color_space_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_color_space_name(AVColorSpace space);
		
		// Func<AVChromaLocation, String>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_chroma_location_name", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String av_chroma_location_name(AVChromaLocation location);
		
		// Action<int*, int*, AVPixFmtDescriptor*>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_fill_max_pixsteps", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_image_fill_max_pixsteps(int* max_pixsteps, int* max_pixstep_comps, AVPixFmtDescriptor* pixdesc);
		
		// Func<AVPixelFormat, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_get_linesize", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_get_linesize(AVPixelFormat pix_fmt, int width, int plane);
		
		// Func<int*, AVPixelFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_fill_linesizes", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_fill_linesizes(int* linesizes, AVPixelFormat pix_fmt, int width);
		
		// Func<byte**, AVPixelFormat, int, byte*, int*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_fill_pointers", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_fill_pointers(byte** data, AVPixelFormat pix_fmt, int height, byte* ptr, int* linesizes);
		
		// Func<byte**, int*, int, int, AVPixelFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_alloc(byte** pointers, int* linesizes, int w, int h, AVPixelFormat pix_fmt, int align);
		
		// Action<byte*, int, byte*, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_copy_plane", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_image_copy_plane(byte* dst, int dst_linesize, byte* src, int src_linesize, int bytewidth, int height);
		
		// Action<byte**, int*, byte**, int*, AVPixelFormat, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_copy", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void av_image_copy(byte** dst_data, int* dst_linesizes, byte** src_data, int* src_linesizes, AVPixelFormat pix_fmt, int width, int height);
		
		// Func<byte**, int*, byte*, AVPixelFormat, int, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_fill_arrays", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_fill_arrays(byte** dst_data, int* dst_linesize, byte* src, AVPixelFormat pix_fmt, int width, int height, int align);
		
		// Func<AVPixelFormat, int, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_get_buffer_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_get_buffer_size(AVPixelFormat pix_fmt, int width, int height, int align);
		
		// Func<byte*, int, byte**, int*, AVPixelFormat, int, int, int, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_copy_to_buffer", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_copy_to_buffer(byte* dst, int dst_size, byte** src_data, int* src_linesize, AVPixelFormat pix_fmt, int width, int height, int align);
		
		// Func<int, int, int, void*, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_check_size", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_check_size(int w, int h, int log_offset, void* log_ctx);
		
		// Func<int, int, AVRational, int>
		[DllImport(AVUTIL_LIBRARY, EntryPoint="av_image_check_sar", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int av_image_check_sar(int w, int h, AVRational sar);
		
		// Func<int>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="postproc_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int postproc_version();
		
		// Func<String>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="postproc_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String postproc_configuration();
		
		// Func<String>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="postproc_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String postproc_license();
		
		// Action<byte**, int*, byte**, int*, int, int, sbyte*, int, pp_mode*, pp_context*, int>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_postprocess", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void pp_postprocess(byte** src, int* srcStride, byte** dst, int* dstStride, int horizontalSize, int verticalSize, sbyte* QP_store, int QP_stride, pp_mode* mode, pp_context* ppContext, int pict_type);
		
		// Func<String, int, pp_mode*>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_get_mode_by_name_and_quality", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern pp_mode* pp_get_mode_by_name_and_quality(String name, int quality);
		
		// Action<pp_mode*>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_free_mode", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void pp_free_mode(pp_mode* mode);
		
		// Func<int, int, int, pp_context*>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_get_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern pp_context* pp_get_context(int width, int height, int flags);
		
		// Action<pp_context*>
		[DllImport(POSTPROC_LIBRARY, EntryPoint="pp_free_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void pp_free_context(pp_context* ppContext);
		
		// Func<AVClass*>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* swr_get_class();
		
		// Func<SwrContext*>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_alloc", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwrContext* swr_alloc();
		
		// Func<SwrContext*, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_init(SwrContext* s);
		
		// Func<SwrContext*, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_is_initialized", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_is_initialized(SwrContext* s);
		
		// Func<SwrContext*, long, AVSampleFormat, int, long, AVSampleFormat, int, int, void*, SwrContext*>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_alloc_set_opts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwrContext* swr_alloc_set_opts(SwrContext* s, long out_ch_layout, AVSampleFormat out_sample_fmt, int out_sample_rate, long in_ch_layout, AVSampleFormat in_sample_fmt, int in_sample_rate, int log_offset, void* log_ctx);
		
		// Action<SwrContext**>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_free", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void swr_free(SwrContext** s);
		
		// Action<SwrContext*>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_close", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void swr_close(SwrContext* s);
		
		// Func<SwrContext*, byte**, int, byte**, int, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_convert", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_convert(SwrContext* s, byte** @out, int out_count, byte** @in, int in_count);
		
		// Func<SwrContext*, long, long>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_next_pts", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long swr_next_pts(SwrContext* s, long pts);
		
		// Func<SwrContext*, int, int, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_set_compensation", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_set_compensation(SwrContext* s, int sample_delta, int compensation_distance);
		
		// Func<SwrContext*, int*, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_set_channel_mapping", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_set_channel_mapping(SwrContext* s, int* channel_map);
		
		// Func<SwrContext*, double*, int, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_set_matrix", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_set_matrix(SwrContext* s, double* matrix, int stride);
		
		// Func<SwrContext*, int, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_drop_output", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_drop_output(SwrContext* s, int count);
		
		// Func<SwrContext*, int, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_inject_silence", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_inject_silence(SwrContext* s, int count);
		
		// Func<SwrContext*, long, long>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_get_delay", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern long swr_get_delay(SwrContext* s, long @base);
		
		// Func<int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swresample_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swresample_version();
		
		// Func<String>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swresample_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swresample_configuration();
		
		// Func<String>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swresample_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swresample_license();
		
		// Func<SwrContext*, AVFrame*, AVFrame*, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_convert_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_convert_frame(SwrContext* swr, AVFrame* output, AVFrame* input);
		
		// Func<SwrContext*, AVFrame*, AVFrame*, int>
		[DllImport(SWRESAMPLE_LIBRARY, EntryPoint="swr_config_frame", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swr_config_frame(SwrContext* swr, AVFrame* @out, AVFrame* @in);
		
		// Func<int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="swscale_version", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int swscale_version();
		
		// Func<String>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="swscale_configuration", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swscale_configuration();
		
		// Func<String>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="swscale_license", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern String swscale_license();
		
		// Func<int, int*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getCoefficients", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int* sws_getCoefficients(int colorspace);
		
		// Func<AVPixelFormat, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_isSupportedInput", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_isSupportedInput(AVPixelFormat pix_fmt);
		
		// Func<AVPixelFormat, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_isSupportedOutput", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_isSupportedOutput(AVPixelFormat pix_fmt);
		
		// Func<AVPixelFormat, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_isSupportedEndiannessConversion", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_isSupportedEndiannessConversion(AVPixelFormat pix_fmt);
		
		// Func<SwsContext*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_alloc_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsContext* sws_alloc_context();
		
		// Func<SwsContext*, SwsFilter*, SwsFilter*, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_init_context", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_init_context(SwsContext* sws_context, SwsFilter* srcFilter, SwsFilter* dstFilter);
		
		// Action<SwsContext*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_freeContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_freeContext(SwsContext* swsContext);
		
		// Func<int, int, AVPixelFormat, int, int, AVPixelFormat, int, SwsFilter*, SwsFilter*, double*, SwsContext*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsContext* sws_getContext(int srcW, int srcH, AVPixelFormat srcFormat, int dstW, int dstH, AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, double* param);
		
		// Func<SwsContext*, byte**, int*, int, int, byte**, int*, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_scale", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_scale(SwsContext* c, byte** srcSlice, int* srcStride, int srcSliceY, int srcSliceH, byte** dst, int* dstStride);
		
		// Func<SwsContext*, int*, int, int*, int, int, int, int, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_setColorspaceDetails", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_setColorspaceDetails(SwsContext* c, int* inv_table, int srcRange, int* table, int dstRange, int brightness, int contrast, int saturation);
		
		// Func<SwsContext*, int**, int*, int**, int*, int*, int*, int*, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getColorspaceDetails", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int sws_getColorspaceDetails(SwsContext* c, int** inv_table, int* srcRange, int** table, int* dstRange, int* brightness, int* contrast, int* saturation);
		
		// Func<int, SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_allocVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_allocVec(int length);
		
		// Func<double, double, SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getGaussianVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_getGaussianVec(double variance, double quality);
		
		// Func<double, int, SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getConstVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_getConstVec(double c, int length);
		
		// Func<SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getIdentityVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_getIdentityVec();
		
		// Action<SwsVector*, double>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_scaleVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_scaleVec(SwsVector* a, double scalar);
		
		// Action<SwsVector*, double>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_normalizeVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_normalizeVec(SwsVector* a, double height);
		
		// Action<SwsVector*, SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_convVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_convVec(SwsVector* a, SwsVector* b);
		
		// Action<SwsVector*, SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_addVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_addVec(SwsVector* a, SwsVector* b);
		
		// Action<SwsVector*, SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_subVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_subVec(SwsVector* a, SwsVector* b);
		
		// Action<SwsVector*, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_shiftVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_shiftVec(SwsVector* a, int shift);
		
		// Func<SwsVector*, SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_cloneVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsVector* sws_cloneVec(SwsVector* a);
		
		// Action<SwsVector*, AVClass*, int>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_printVec2", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_printVec2(SwsVector* a, AVClass* log_ctx, int log_level);
		
		// Action<SwsVector*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_freeVec", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_freeVec(SwsVector* a);
		
		// Func<float, float, float, float, float, float, int, SwsFilter*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getDefaultFilter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsFilter* sws_getDefaultFilter(float lumaGBlur, float chromaGBlur, float lumaSharpen, float chromaSharpen, float chromaHShift, float chromaVShift, int verbose);
		
		// Action<SwsFilter*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_freeFilter", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_freeFilter(SwsFilter* filter);
		
		// Func<SwsContext*, int, int, AVPixelFormat, int, int, AVPixelFormat, int, SwsFilter*, SwsFilter*, double*, SwsContext*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_getCachedContext", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern SwsContext* sws_getCachedContext(SwsContext* context, int srcW, int srcH, AVPixelFormat srcFormat, int dstW, int dstH, AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, double* param);
		
		// Action<byte*, byte*, int, byte*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_convertPalette8ToPacked32", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_convertPalette8ToPacked32(byte* src, byte* dst, int num_pixels, byte* palette);
		
		// Action<byte*, byte*, int, byte*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_convertPalette8ToPacked24", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void sws_convertPalette8ToPacked24(byte* src, byte* dst, int num_pixels, byte* palette);
		
		// Func<AVClass*>
		[DllImport(SWSCALE_LIBRARY, EntryPoint="sws_get_class", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern AVClass* sws_get_class();
		
	}
}
