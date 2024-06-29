; ModuleID = 'obj\Release\130\android\marshal_methods.x86.ll'
source_filename = "obj\Release\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [132 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 60
	i32 39109920, ; 1: Newtonsoft.Json.dll => 0x254c520 => 39
	i32 57263871, ; 2: Xamarin.Forms.Core.dll => 0x369c6ff => 55
	i32 182336117, ; 3: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 27
	i32 299357484, ; 4: News_aggregator.Android => 0x11d7d52c => 64
	i32 318968648, ; 5: Xamarin.AndroidX.Activity.dll => 0x13031348 => 48
	i32 321597661, ; 6: System.Numerics => 0x132b30dd => 8
	i32 342366114, ; 7: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 22
	i32 347068432, ; 8: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 43
	i32 393699800, ; 9: Firebase => 0x177761d8 => 36
	i32 442521989, ; 10: Xamarin.Essentials => 0x1a605985 => 51
	i32 450948140, ; 11: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 20
	i32 465846621, ; 12: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 13: System.dll => 0x1bff388e => 7
	i32 474644222, ; 14: News_aggregator.dll => 0x1c4a7efe => 65
	i32 610194910, ; 15: System.Reactive.dll => 0x245ed5de => 46
	i32 627609679, ; 16: Xamarin.AndroidX.CustomView => 0x2568904f => 18
	i32 690569205, ; 17: System.Xml.Linq.dll => 0x29293ff5 => 11
	i32 700284507, ; 18: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 63
	i32 748832960, ; 19: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 41
	i32 809851609, ; 20: System.Drawing.Common.dll => 0x30455ad9 => 32
	i32 928116545, ; 21: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 60
	i32 955402788, ; 22: Newtonsoft.Json => 0x38f24a24 => 39
	i32 967690846, ; 23: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 22
	i32 974778368, ; 24: FormsViewGroup.dll => 0x3a19f000 => 37
	i32 1012816738, ; 25: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 49
	i32 1035644815, ; 26: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 13
	i32 1042160112, ; 27: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 58
	i32 1052210849, ; 28: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 24
	i32 1098259244, ; 29: System => 0x41761b2c => 7
	i32 1110581358, ; 30: Xamarin.Firebase.Auth => 0x4232206e => 52
	i32 1197356489, ; 31: News_aggregator => 0x475e35c9 => 65
	i32 1292207520, ; 32: SQLitePCLRaw.core.dll => 0x4d0585a0 => 42
	i32 1293217323, ; 33: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 19
	i32 1333047053, ; 34: Xamarin.Firebase.Common => 0x4f74af0d => 54
	i32 1365406463, ; 35: System.ServiceModel.Internals.dll => 0x516272ff => 30
	i32 1376866003, ; 36: Xamarin.AndroidX.SavedState => 0x52114ed3 => 49
	i32 1406073936, ; 37: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 15
	i32 1411638395, ; 38: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 9
	i32 1411702249, ; 39: Xamarin.Firebase.Auth.Interop.dll => 0x5424dde9 => 53
	i32 1460219004, ; 40: Xamarin.Forms.Xaml => 0x57092c7c => 59
	i32 1461234159, ; 41: System.Collections.Immutable.dll => 0x5718a9ef => 45
	i32 1469204771, ; 42: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 12
	i32 1479771757, ; 43: System.Collections.Immutable => 0x5833866d => 45
	i32 1592978981, ; 44: System.Runtime.Serialization.dll => 0x5ef2ee25 => 1
	i32 1622152042, ; 45: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 25
	i32 1636350590, ; 46: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 17
	i32 1639515021, ; 47: System.Net.Http.dll => 0x61b9038d => 0
	i32 1658251792, ; 48: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 29
	i32 1691477237, ; 49: System.Reflection.Metadata => 0x64d1e4f5 => 47
	i32 1711441057, ; 50: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 43
	i32 1729485958, ; 51: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 14
	i32 1766324549, ; 52: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 27
	i32 1776026572, ; 53: System.Core.dll => 0x69dc03cc => 6
	i32 1781418309, ; 54: AngleSharp => 0x6a2e4945 => 35
	i32 1788241197, ; 55: Xamarin.AndroidX.Fragment => 0x6a96652d => 20
	i32 1808609942, ; 56: Xamarin.AndroidX.Loader => 0x6bcd3296 => 25
	i32 1813201214, ; 57: Xamarin.Google.Android.Material => 0x6c13413e => 29
	i32 1867746548, ; 58: Xamarin.Essentials.dll => 0x6f538cf4 => 51
	i32 1875053220, ; 59: Xamarin.Firebase.Auth.Interop => 0x6fc30aa4 => 53
	i32 1878053835, ; 60: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 59
	i32 1889954781, ; 61: System.Reflection.Metadata.dll => 0x70a66bdd => 47
	i32 1908813208, ; 62: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 61
	i32 2011961780, ; 63: System.Buffers.dll => 0x77ec19b4 => 5
	i32 2019465201, ; 64: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 24
	i32 2055257422, ; 65: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 23
	i32 2097448633, ; 66: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 21
	i32 2103459038, ; 67: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 44
	i32 2113902067, ; 68: Xamarin.Forms.PancakeView.dll => 0x7dff95f3 => 56
	i32 2126786730, ; 69: Xamarin.Forms.Platform.Android => 0x7ec430aa => 57
	i32 2201231467, ; 70: System.Net.Http => 0x8334206b => 0
	i32 2275458144, ; 71: AngleSharp.dll => 0x87a0bc60 => 35
	i32 2279755925, ; 72: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 26
	i32 2382033717, ; 73: Xamarin.Firebase.Auth.dll => 0x8dfaf335 => 52
	i32 2397082276, ; 74: Xamarin.Forms.PancakeView => 0x8ee092a4 => 56
	i32 2465273461, ; 75: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 41
	i32 2475788418, ; 76: Java.Interop.dll => 0x93918882 => 2
	i32 2620871830, ; 77: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 17
	i32 2732626843, ; 78: Xamarin.AndroidX.Activity => 0xa2e0939b => 48
	i32 2737747696, ; 79: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 12
	i32 2765824710, ; 80: System.Text.Encoding.CodePages.dll => 0xa4db22c6 => 33
	i32 2766581644, ; 81: Xamarin.Forms.Core => 0xa4e6af8c => 55
	i32 2770495804, ; 82: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 63
	i32 2778768386, ; 83: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 28
	i32 2810250172, ; 84: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 15
	i32 2819470561, ; 85: System.Xml.dll => 0xa80db4e1 => 10
	i32 2853208004, ; 86: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 28
	i32 2905242038, ; 87: mscorlib.dll => 0xad2a79b6 => 4
	i32 2978675010, ; 88: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 19
	i32 3044182254, ; 89: FormsViewGroup => 0xb57288ee => 37
	i32 3058099980, ; 90: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 62
	i32 3071899978, ; 91: Xamarin.Firebase.Common.dll => 0xb719794a => 54
	i32 3111772706, ; 92: System.Runtime.Serialization => 0xb979e222 => 1
	i32 3204380047, ; 93: System.Data.dll => 0xbefef58f => 31
	i32 3230466174, ; 94: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 61
	i32 3247949154, ; 95: Mono.Security => 0xc197c562 => 34
	i32 3258312781, ; 96: Xamarin.AndroidX.CardView => 0xc235e84d => 14
	i32 3286872994, ; 97: SQLite-net.dll => 0xc3e9b3a2 => 40
	i32 3317135071, ; 98: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 18
	i32 3317144872, ; 99: System.Data => 0xc5b79d28 => 31
	i32 3322403133, ; 100: Firebase.dll => 0xc607d93d => 36
	i32 3353484488, ; 101: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 21
	i32 3353544232, ; 102: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 50
	i32 3360279109, ; 103: SQLitePCLRaw.core => 0xc849ca45 => 42
	i32 3362522851, ; 104: Xamarin.AndroidX.Core => 0xc86c06e3 => 16
	i32 3366347497, ; 105: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 106: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 26
	i32 3395150330, ; 107: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 9
	i32 3404865022, ; 108: System.ServiceModel.Internals => 0xcaf21dfe => 30
	i32 3407215217, ; 109: Xamarin.CommunityToolkit => 0xcb15fa71 => 50
	i32 3429136800, ; 110: System.Xml => 0xcc6479a0 => 10
	i32 3476120550, ; 111: Mono.Android => 0xcf3163e6 => 3
	i32 3509114376, ; 112: System.Xml.Linq => 0xd128d608 => 11
	i32 3536029504, ; 113: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 57
	i32 3596207933, ; 114: LiteDB.dll => 0xd659c73d => 38
	i32 3608450223, ; 115: News_aggregator.Android.dll => 0xd71494af => 64
	i32 3629588173, ; 116: LiteDB => 0xd8571ecd => 38
	i32 3632359727, ; 117: Xamarin.Forms.Platform => 0xd881692f => 58
	i32 3641597786, ; 118: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 23
	i32 3672681054, ; 119: Mono.Android.dll => 0xdae8aa5e => 3
	i32 3689375977, ; 120: System.Drawing.Common => 0xdbe768e9 => 32
	i32 3731644420, ; 121: System.Reactive => 0xde6c6004 => 46
	i32 3754567612, ; 122: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 44
	i32 3829621856, ; 123: System.Numerics.dll => 0xe4436460 => 8
	i32 3876362041, ; 124: SQLite-net => 0xe70c9739 => 40
	i32 3896760992, ; 125: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 16
	i32 3953953790, ; 126: System.Text.Encoding.CodePages => 0xebac8bfe => 33
	i32 3955647286, ; 127: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 13
	i32 3970018735, ; 128: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 62
	i32 4105002889, ; 129: Mono.Security.dll => 0xf4ad5f89 => 34
	i32 4151237749, ; 130: System.Core => 0xf76edc75 => 6
	i32 4260525087 ; 131: System.Buffers => 0xfdf2741f => 5
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [132 x i32] [
	i32 60, i32 39, i32 55, i32 27, i32 64, i32 48, i32 8, i32 22, ; 0..7
	i32 43, i32 36, i32 51, i32 20, i32 4, i32 7, i32 65, i32 46, ; 8..15
	i32 18, i32 11, i32 63, i32 41, i32 32, i32 60, i32 39, i32 22, ; 16..23
	i32 37, i32 49, i32 13, i32 58, i32 24, i32 7, i32 52, i32 65, ; 24..31
	i32 42, i32 19, i32 54, i32 30, i32 49, i32 15, i32 9, i32 53, ; 32..39
	i32 59, i32 45, i32 12, i32 45, i32 1, i32 25, i32 17, i32 0, ; 40..47
	i32 29, i32 47, i32 43, i32 14, i32 27, i32 6, i32 35, i32 20, ; 48..55
	i32 25, i32 29, i32 51, i32 53, i32 59, i32 47, i32 61, i32 5, ; 56..63
	i32 24, i32 23, i32 21, i32 44, i32 56, i32 57, i32 0, i32 35, ; 64..71
	i32 26, i32 52, i32 56, i32 41, i32 2, i32 17, i32 48, i32 12, ; 72..79
	i32 33, i32 55, i32 63, i32 28, i32 15, i32 10, i32 28, i32 4, ; 80..87
	i32 19, i32 37, i32 62, i32 54, i32 1, i32 31, i32 61, i32 34, ; 88..95
	i32 14, i32 40, i32 18, i32 31, i32 36, i32 21, i32 50, i32 42, ; 96..103
	i32 16, i32 2, i32 26, i32 9, i32 30, i32 50, i32 10, i32 3, ; 104..111
	i32 11, i32 57, i32 38, i32 64, i32 38, i32 58, i32 23, i32 3, ; 112..119
	i32 32, i32 46, i32 44, i32 8, i32 40, i32 16, i32 33, i32 13, ; 120..127
	i32 62, i32 34, i32 6, i32 5 ; 128..131
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
