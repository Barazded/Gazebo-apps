; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [230 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 62
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 96
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 12
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 91
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 76
	i32 103834273, ; 5: Xamarin.Firebase.Annotations.dll => 0x63062a1 => 86
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 76
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 43
	i32 182336117, ; 8: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 77
	i32 209399409, ; 9: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 41
	i32 230216969, ; 10: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 57
	i32 232815796, ; 11: System.Web.Services => 0xde07cb4 => 112
	i32 261689757, ; 12: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 46
	i32 278686392, ; 13: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 61
	i32 280482487, ; 14: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 55
	i32 293936332, ; 15: Xamarin.GooglePlayServices.Auth.Api.Phone.dll => 0x11851ccc => 97
	i32 299357484, ; 16: News_aggregator.Android => 0x11d7d52c => 0
	i32 318968648, ; 17: Xamarin.AndroidX.Activity.dll => 0x13031348 => 33
	i32 321597661, ; 18: System.Numerics => 0x132b30dd => 24
	i32 342366114, ; 19: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 59
	i32 347068432, ; 20: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 16
	i32 385762202, ; 21: System.Memory.dll => 0x16fe439a => 23
	i32 393699800, ; 22: Firebase => 0x177761d8 => 5
	i32 437821906, ; 23: Xamarin.GooglePlayServices.SafetyNet => 0x1a18a1d2 => 100
	i32 441335492, ; 24: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 45
	i32 442521989, ; 25: Xamarin.Essentials => 0x1a605985 => 85
	i32 450948140, ; 26: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 54
	i32 465846621, ; 27: mscorlib => 0x1bc4415d => 10
	i32 469710990, ; 28: System.dll => 0x1bff388e => 21
	i32 474644222, ; 29: News_aggregator.dll => 0x1c4a7efe => 11
	i32 476646585, ; 30: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 55
	i32 486930444, ; 31: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 66
	i32 526420162, ; 32: System.Transactions.dll => 0x1f6088c2 => 106
	i32 589597883, ; 33: Xamarin.GooglePlayServices.Auth.Api.Phone => 0x23248cbb => 97
	i32 605376203, ; 34: System.IO.Compression.FileSystem => 0x24154ecb => 110
	i32 610194910, ; 35: System.Reactive.dll => 0x245ed5de => 26
	i32 627609679, ; 36: Xamarin.AndroidX.CustomView => 0x2568904f => 50
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 82
	i32 666292255, ; 38: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 38
	i32 690569205, ; 39: System.Xml.Linq.dll => 0x29293ff5 => 31
	i32 692692150, ; 40: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 32
	i32 700284507, ; 41: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 102
	i32 748832960, ; 42: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 14
	i32 775507847, ; 43: System.IO.Compression => 0x2e394f87 => 109
	i32 809851609, ; 44: System.Drawing.Common.dll => 0x30455ad9 => 108
	i32 843511501, ; 45: Xamarin.AndroidX.Print => 0x3246f6cd => 73
	i32 928116545, ; 46: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 96
	i32 955402788, ; 47: Newtonsoft.Json => 0x38f24a24 => 12
	i32 967690846, ; 48: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 59
	i32 974778368, ; 49: FormsViewGroup.dll => 0x3a19f000 => 6
	i32 1012816738, ; 50: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 75
	i32 1035644815, ; 51: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 37
	i32 1042160112, ; 52: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 93
	i32 1052210849, ; 53: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 63
	i32 1098259244, ; 54: System => 0x41761b2c => 21
	i32 1110581358, ; 55: Xamarin.Firebase.Auth => 0x4232206e => 87
	i32 1175144683, ; 56: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 80
	i32 1178241025, ; 57: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 70
	i32 1197356489, ; 58: News_aggregator => 0x475e35c9 => 11
	i32 1204270330, ; 59: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 38
	i32 1267360935, ; 60: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 81
	i32 1292207520, ; 61: SQLitePCLRaw.core.dll => 0x4d0585a0 => 15
	i32 1293217323, ; 62: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 52
	i32 1333047053, ; 63: Xamarin.Firebase.Common => 0x4f74af0d => 89
	i32 1365406463, ; 64: System.ServiceModel.Internals.dll => 0x516272ff => 103
	i32 1376866003, ; 65: Xamarin.AndroidX.SavedState => 0x52114ed3 => 75
	i32 1395857551, ; 66: Xamarin.AndroidX.Media.dll => 0x5333188f => 67
	i32 1406073936, ; 67: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 47
	i32 1411638395, ; 68: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 28
	i32 1411702249, ; 69: Xamarin.Firebase.Auth.Interop.dll => 0x5424dde9 => 88
	i32 1460219004, ; 70: Xamarin.Forms.Xaml => 0x57092c7c => 94
	i32 1461234159, ; 71: System.Collections.Immutable.dll => 0x5718a9ef => 19
	i32 1462112819, ; 72: System.IO.Compression.dll => 0x57261233 => 109
	i32 1469204771, ; 73: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 36
	i32 1479771757, ; 74: System.Collections.Immutable => 0x5833866d => 19
	i32 1582372066, ; 75: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 51
	i32 1592978981, ; 76: System.Runtime.Serialization.dll => 0x5ef2ee25 => 3
	i32 1622152042, ; 77: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 65
	i32 1624863272, ; 78: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 84
	i32 1636350590, ; 79: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 49
	i32 1639515021, ; 80: System.Net.Http.dll => 0x61b9038d => 2
	i32 1657153582, ; 81: System.Runtime => 0x62c6282e => 29
	i32 1658241508, ; 82: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 78
	i32 1658251792, ; 83: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 95
	i32 1670060433, ; 84: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 46
	i32 1691477237, ; 85: System.Reflection.Metadata => 0x64d1e4f5 => 27
	i32 1711441057, ; 86: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 16
	i32 1729485958, ; 87: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 42
	i32 1766324549, ; 88: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 77
	i32 1776026572, ; 89: System.Core.dll => 0x69dc03cc => 20
	i32 1781418309, ; 90: AngleSharp => 0x6a2e4945 => 4
	i32 1788241197, ; 91: Xamarin.AndroidX.Fragment => 0x6a96652d => 54
	i32 1808609942, ; 92: Xamarin.AndroidX.Loader => 0x6bcd3296 => 65
	i32 1813201214, ; 93: Xamarin.Google.Android.Material => 0x6c13413e => 95
	i32 1818569960, ; 94: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 71
	i32 1867746548, ; 95: Xamarin.Essentials.dll => 0x6f538cf4 => 85
	i32 1875053220, ; 96: Xamarin.Firebase.Auth.Interop => 0x6fc30aa4 => 88
	i32 1878053835, ; 97: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 94
	i32 1885316902, ; 98: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 39
	i32 1889954781, ; 99: System.Reflection.Metadata.dll => 0x70a66bdd => 27
	i32 1904755420, ; 100: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 1
	i32 1908813208, ; 101: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 99
	i32 1919157823, ; 102: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 68
	i32 2011961780, ; 103: System.Buffers.dll => 0x77ec19b4 => 18
	i32 2019465201, ; 104: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 63
	i32 2055257422, ; 105: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 60
	i32 2079903147, ; 106: System.Runtime.dll => 0x7bf8cdab => 29
	i32 2090596640, ; 107: System.Numerics.Vectors => 0x7c9bf920 => 25
	i32 2097448633, ; 108: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 56
	i32 2103459038, ; 109: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 17
	i32 2126786730, ; 110: Xamarin.Forms.Platform.Android => 0x7ec430aa => 92
	i32 2129483829, ; 111: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 98
	i32 2174878672, ; 112: Xamarin.Firebase.Annotations => 0x81a203d0 => 86
	i32 2188064486, ; 113: System.Json.dll => 0x826b36e6 => 22
	i32 2201231467, ; 114: System.Net.Http => 0x8334206b => 2
	i32 2217644978, ; 115: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 80
	i32 2244775296, ; 116: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 66
	i32 2256548716, ; 117: Xamarin.AndroidX.MultiDex => 0x8680336c => 68
	i32 2261435625, ; 118: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 58
	i32 2275458144, ; 119: AngleSharp.dll => 0x87a0bc60 => 4
	i32 2279755925, ; 120: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 74
	i32 2315684594, ; 121: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 34
	i32 2382033717, ; 122: Xamarin.Firebase.Auth.dll => 0x8dfaf335 => 87
	i32 2409053734, ; 123: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 72
	i32 2465273461, ; 124: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 14
	i32 2465532216, ; 125: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 45
	i32 2471841756, ; 126: netstandard.dll => 0x93554fdc => 104
	i32 2475788418, ; 127: Java.Interop.dll => 0x93918882 => 7
	i32 2501346920, ; 128: System.Data.DataSetExtensions => 0x95178668 => 107
	i32 2505896520, ; 129: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 62
	i32 2581819634, ; 130: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 81
	i32 2620871830, ; 131: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 49
	i32 2624644809, ; 132: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 53
	i32 2633051222, ; 133: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 61
	i32 2701096212, ; 134: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 78
	i32 2732626843, ; 135: Xamarin.AndroidX.Activity => 0xa2e0939b => 33
	i32 2737747696, ; 136: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 36
	i32 2765824710, ; 137: System.Text.Encoding.CodePages.dll => 0xa4db22c6 => 113
	i32 2766581644, ; 138: Xamarin.Forms.Core => 0xa4e6af8c => 91
	i32 2770495804, ; 139: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 102
	i32 2778768386, ; 140: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 83
	i32 2804607052, ; 141: Xamarin.Firebase.Components.dll => 0xa72ae84c => 90
	i32 2810250172, ; 142: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 47
	i32 2819470561, ; 143: System.Xml.dll => 0xa80db4e1 => 30
	i32 2847418871, ; 144: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 98
	i32 2853208004, ; 145: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 83
	i32 2855708567, ; 146: Xamarin.AndroidX.Transition => 0xaa36a797 => 79
	i32 2903344695, ; 147: System.ComponentModel.Composition => 0xad0d8637 => 111
	i32 2905242038, ; 148: mscorlib.dll => 0xad2a79b6 => 10
	i32 2916838712, ; 149: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 84
	i32 2919462931, ; 150: System.Numerics.Vectors.dll => 0xae037813 => 25
	i32 2921128767, ; 151: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 35
	i32 2978675010, ; 152: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 52
	i32 3024354802, ; 153: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 57
	i32 3044182254, ; 154: FormsViewGroup => 0xb57288ee => 6
	i32 3057625584, ; 155: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 69
	i32 3058099980, ; 156: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 101
	i32 3066684652, ; 157: Xamarin.GooglePlayServices.SafetyNet.dll => 0xb6c9e4ec => 100
	i32 3071899978, ; 158: Xamarin.Firebase.Common.dll => 0xb719794a => 89
	i32 3111772706, ; 159: System.Runtime.Serialization => 0xb979e222 => 3
	i32 3201217166, ; 160: System.Json => 0xbeceb28e => 22
	i32 3204380047, ; 161: System.Data.dll => 0xbefef58f => 105
	i32 3211777861, ; 162: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 51
	i32 3230466174, ; 163: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 99
	i32 3247949154, ; 164: Mono.Security => 0xc197c562 => 114
	i32 3258312781, ; 165: Xamarin.AndroidX.CardView => 0xc235e84d => 42
	i32 3267021929, ; 166: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 40
	i32 3286872994, ; 167: SQLite-net.dll => 0xc3e9b3a2 => 13
	i32 3317135071, ; 168: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 50
	i32 3317144872, ; 169: System.Data => 0xc5b79d28 => 105
	i32 3322403133, ; 170: Firebase.dll => 0xc607d93d => 5
	i32 3340431453, ; 171: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 39
	i32 3346324047, ; 172: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 70
	i32 3353484488, ; 173: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 56
	i32 3360279109, ; 174: SQLitePCLRaw.core => 0xc849ca45 => 15
	i32 3362522851, ; 175: Xamarin.AndroidX.Core => 0xc86c06e3 => 48
	i32 3366347497, ; 176: Java.Interop => 0xc8a662e9 => 7
	i32 3374999561, ; 177: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 74
	i32 3395150330, ; 178: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 28
	i32 3404865022, ; 179: System.ServiceModel.Internals => 0xcaf21dfe => 103
	i32 3429136800, ; 180: System.Xml => 0xcc6479a0 => 30
	i32 3430777524, ; 181: netstandard => 0xcc7d82b4 => 104
	i32 3439690031, ; 182: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 32
	i32 3441283291, ; 183: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 53
	i32 3476120550, ; 184: Mono.Android => 0xcf3163e6 => 9
	i32 3486566296, ; 185: System.Transactions => 0xcfd0c798 => 106
	i32 3493954962, ; 186: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 44
	i32 3501239056, ; 187: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 40
	i32 3509114376, ; 188: System.Xml.Linq => 0xd128d608 => 31
	i32 3536029504, ; 189: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 92
	i32 3567349600, ; 190: System.ComponentModel.Composition.dll => 0xd4a16f60 => 111
	i32 3596207933, ; 191: LiteDB.dll => 0xd659c73d => 8
	i32 3608450223, ; 192: News_aggregator.Android.dll => 0xd71494af => 0
	i32 3618140916, ; 193: Xamarin.AndroidX.Preference => 0xd7a872f4 => 72
	i32 3627220390, ; 194: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 73
	i32 3629588173, ; 195: LiteDB => 0xd8571ecd => 8
	i32 3632359727, ; 196: Xamarin.Forms.Platform => 0xd881692f => 93
	i32 3633644679, ; 197: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 35
	i32 3641597786, ; 198: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 60
	i32 3672681054, ; 199: Mono.Android.dll => 0xdae8aa5e => 9
	i32 3676310014, ; 200: System.Web.Services.dll => 0xdb2009fe => 112
	i32 3682565725, ; 201: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 41
	i32 3684561358, ; 202: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 44
	i32 3684933406, ; 203: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 1
	i32 3689375977, ; 204: System.Drawing.Common => 0xdbe768e9 => 108
	i32 3718780102, ; 205: Xamarin.AndroidX.Annotation => 0xdda814c6 => 34
	i32 3724971120, ; 206: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 69
	i32 3731644420, ; 207: System.Reactive => 0xde6c6004 => 26
	i32 3754567612, ; 208: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 17
	i32 3758932259, ; 209: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 58
	i32 3786282454, ; 210: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 43
	i32 3822602673, ; 211: Xamarin.AndroidX.Media => 0xe3d849b1 => 67
	i32 3829621856, ; 212: System.Numerics.dll => 0xe4436460 => 24
	i32 3876362041, ; 213: SQLite-net => 0xe70c9739 => 13
	i32 3885922214, ; 214: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 79
	i32 3896760992, ; 215: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 48
	i32 3920810846, ; 216: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 110
	i32 3921031405, ; 217: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 82
	i32 3931092270, ; 218: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 71
	i32 3945713374, ; 219: System.Data.DataSetExtensions.dll => 0xeb2ecede => 107
	i32 3953953790, ; 220: System.Text.Encoding.CodePages => 0xebac8bfe => 113
	i32 3955647286, ; 221: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 37
	i32 3970018735, ; 222: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 101
	i32 4025784931, ; 223: System.Memory => 0xeff49a63 => 23
	i32 4105002889, ; 224: Mono.Security.dll => 0xf4ad5f89 => 114
	i32 4151237749, ; 225: System.Core => 0xf76edc75 => 20
	i32 4182413190, ; 226: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 64
	i32 4260525087, ; 227: System.Buffers => 0xfdf2741f => 18
	i32 4284549794, ; 228: Xamarin.Firebase.Components => 0xff610aa2 => 90
	i32 4292120959 ; 229: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 64
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [230 x i32] [
	i32 62, i32 96, i32 12, i32 91, i32 76, i32 86, i32 76, i32 43, ; 0..7
	i32 77, i32 41, i32 57, i32 112, i32 46, i32 61, i32 55, i32 97, ; 8..15
	i32 0, i32 33, i32 24, i32 59, i32 16, i32 23, i32 5, i32 100, ; 16..23
	i32 45, i32 85, i32 54, i32 10, i32 21, i32 11, i32 55, i32 66, ; 24..31
	i32 106, i32 97, i32 110, i32 26, i32 50, i32 82, i32 38, i32 31, ; 32..39
	i32 32, i32 102, i32 14, i32 109, i32 108, i32 73, i32 96, i32 12, ; 40..47
	i32 59, i32 6, i32 75, i32 37, i32 93, i32 63, i32 21, i32 87, ; 48..55
	i32 80, i32 70, i32 11, i32 38, i32 81, i32 15, i32 52, i32 89, ; 56..63
	i32 103, i32 75, i32 67, i32 47, i32 28, i32 88, i32 94, i32 19, ; 64..71
	i32 109, i32 36, i32 19, i32 51, i32 3, i32 65, i32 84, i32 49, ; 72..79
	i32 2, i32 29, i32 78, i32 95, i32 46, i32 27, i32 16, i32 42, ; 80..87
	i32 77, i32 20, i32 4, i32 54, i32 65, i32 95, i32 71, i32 85, ; 88..95
	i32 88, i32 94, i32 39, i32 27, i32 1, i32 99, i32 68, i32 18, ; 96..103
	i32 63, i32 60, i32 29, i32 25, i32 56, i32 17, i32 92, i32 98, ; 104..111
	i32 86, i32 22, i32 2, i32 80, i32 66, i32 68, i32 58, i32 4, ; 112..119
	i32 74, i32 34, i32 87, i32 72, i32 14, i32 45, i32 104, i32 7, ; 120..127
	i32 107, i32 62, i32 81, i32 49, i32 53, i32 61, i32 78, i32 33, ; 128..135
	i32 36, i32 113, i32 91, i32 102, i32 83, i32 90, i32 47, i32 30, ; 136..143
	i32 98, i32 83, i32 79, i32 111, i32 10, i32 84, i32 25, i32 35, ; 144..151
	i32 52, i32 57, i32 6, i32 69, i32 101, i32 100, i32 89, i32 3, ; 152..159
	i32 22, i32 105, i32 51, i32 99, i32 114, i32 42, i32 40, i32 13, ; 160..167
	i32 50, i32 105, i32 5, i32 39, i32 70, i32 56, i32 15, i32 48, ; 168..175
	i32 7, i32 74, i32 28, i32 103, i32 30, i32 104, i32 32, i32 53, ; 176..183
	i32 9, i32 106, i32 44, i32 40, i32 31, i32 92, i32 111, i32 8, ; 184..191
	i32 0, i32 72, i32 73, i32 8, i32 93, i32 35, i32 60, i32 9, ; 192..199
	i32 112, i32 41, i32 44, i32 1, i32 108, i32 34, i32 69, i32 26, ; 200..207
	i32 17, i32 58, i32 43, i32 67, i32 24, i32 13, i32 79, i32 48, ; 208..215
	i32 110, i32 82, i32 71, i32 107, i32 113, i32 37, i32 101, i32 23, ; 216..223
	i32 114, i32 20, i32 64, i32 18, i32 90, i32 64 ; 224..229
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
