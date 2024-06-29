; ModuleID = 'obj\Release\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Release\130\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [132 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 3
	i64 232391251801502327, ; 1: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 49
	i64 376821212072123757, ; 2: AngleSharp.dll => 0x53abce559641d6d => 35
	i64 464346026994987652, ; 3: System.Reactive.dll => 0x671b04057e67284 => 46
	i64 702024105029695270, ; 4: System.Drawing.Common => 0x9be17343c0e7726 => 32
	i64 720058930071658100, ; 5: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 21
	i64 870603111519317375, ; 6: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 43
	i64 872800313462103108, ; 7: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 19
	i64 996343623809489702, ; 8: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 58
	i64 1000557547492888992, ; 9: Mono.Security.dll => 0xde2b1c9cba651a0 => 34
	i64 1120440138749646132, ; 10: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 29
	i64 1301485588176585670, ; 11: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 42
	i64 1392315331768750440, ; 12: Xamarin.Firebase.Auth.Interop.dll => 0x13527f6add681168 => 53
	i64 1425944114962822056, ; 13: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 1
	i64 1518315023656898250, ; 14: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 44
	i64 1624659445732251991, ; 15: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 12
	i64 1731380447121279447, ; 16: Newtonsoft.Json => 0x18071957e9b889d7 => 39
	i64 1795316252682057001, ; 17: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 13
	i64 1836611346387731153, ; 18: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 49
	i64 1981742497975770890, ; 19: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 24
	i64 1986553961460820075, ; 20: Xamarin.CommunityToolkit => 0x1b91a84d8004686b => 50
	i64 2133195048986300728, ; 21: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 39
	i64 2262844636196693701, ; 22: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 19
	i64 2329709569556905518, ; 23: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 23
	i64 2337758774805907496, ; 24: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 9
	i64 2470498323731680442, ; 25: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 15
	i64 2547086958574651984, ; 26: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 48
	i64 2549645802113351205, ; 27: News_aggregator => 0x2362295932083e25 => 65
	i64 2592350477072141967, ; 28: System.Xml.dll => 0x23f9e10627330e8f => 10
	i64 2624866290265602282, ; 29: mscorlib.dll => 0x246d65fbde2db8ea => 4
	i64 2783046991838674048, ; 30: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 9
	i64 2960931600190307745, ; 31: Xamarin.Forms.Core => 0x2917579a49927da1 => 55
	i64 3017704767998173186, ; 32: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 29
	i64 3289520064315143713, ; 33: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 22
	i64 3364695309916733813, ; 34: Xamarin.Firebase.Common => 0x2eb1cc8eb5028175 => 54
	i64 3411255996856937470, ; 35: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 61
	i64 3522470458906976663, ; 36: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 27
	i64 3531994851595924923, ; 37: System.Numerics => 0x31042a9aade235bb => 8
	i64 3727469159507183293, ; 38: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 26
	i64 3978647773165252022, ; 39: News_aggregator.dll => 0x3736ff11e5e9edb6 => 65
	i64 4247996603072512073, ; 40: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 62
	i64 4337444564132831293, ; 41: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 41
	i64 4525561845656915374, ; 42: System.ServiceModel.Internals => 0x3ece06856b710dae => 30
	i64 4794310189461587505, ; 43: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 48
	i64 4795410492532947900, ; 44: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 27
	i64 5142919913060024034, ; 45: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 57
	i64 5203618020066742981, ; 46: Xamarin.Essentials => 0x4836f704f0e652c5 => 51
	i64 5312372435986440853, ; 47: News_aggregator.Android => 0x49b95695998c6295 => 64
	i64 5375264076663995773, ; 48: Xamarin.Forms.PancakeView => 0x4a98c632c779bd7d => 56
	i64 5507995362134886206, ; 49: System.Core.dll => 0x4c705499688c873e => 6
	i64 6085203216496545422, ; 50: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 58
	i64 6086316965293125504, ; 51: FormsViewGroup.dll => 0x5476f10882baef80 => 37
	i64 6183170893902868313, ; 52: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 41
	i64 6401687960814735282, ; 53: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 23
	i64 6403742896930319886, ; 54: Xamarin.Firebase.Auth.dll => 0x58deaa3c7c766e0e => 52
	i64 6548213210057960872, ; 55: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 18
	i64 6617685658146568858, ; 56: System.Text.Encoding.CodePages => 0x5bd6be0b4905fa9a => 33
	i64 6659513131007730089, ; 57: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 21
	i64 6876862101832370452, ; 58: System.Xml.Linq => 0x5f6f85a57d108914 => 11
	i64 7488575175965059935, ; 59: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 11
	i64 7602111570124318452, ; 60: System.Reactive => 0x698020320025a6f4 => 46
	i64 7635363394907363464, ; 61: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 55
	i64 7637365915383206639, ; 62: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 51
	i64 7654504624184590948, ; 63: System.Net.Http => 0x6a3a4366801b8264 => 0
	i64 7820441508502274321, ; 64: System.Data => 0x6c87ca1e14ff8111 => 31
	i64 7836164640616011524, ; 65: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 12
	i64 8083354569033831015, ; 66: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 22
	i64 8167236081217502503, ; 67: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 2
	i64 8518412311883997971, ; 68: System.Collections.Immutable => 0x76377add7c28e313 => 45
	i64 8626175481042262068, ; 69: Java.Interop => 0x77b654e585b55834 => 2
	i64 8702320156596882678, ; 70: Firebase.dll => 0x78c4da1357adccf6 => 36
	i64 9057635389615298436, ; 71: LiteDB => 0x7db32f65bf06d784 => 38
	i64 9296667808972889535, ; 72: LiteDB.dll => 0x8104661dcca35dbf => 38
	i64 9324707631942237306, ; 73: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 13
	i64 9662334977499516867, ; 74: System.Numerics.dll => 0x8617827802b0cfc3 => 8
	i64 9678050649315576968, ; 75: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 15
	i64 9808709177481450983, ; 76: Mono.Android.dll => 0x881f890734e555e7 => 3
	i64 9836529246295212050, ; 77: System.Reflection.Metadata => 0x88825f3bbc2ac012 => 47
	i64 9998632235833408227, ; 78: Mono.Security => 0x8ac2470b209ebae3 => 34
	i64 10038780035334861115, ; 79: System.Net.Http.dll => 0x8b50e941206af13b => 0
	i64 10144742755892837524, ; 80: Firebase => 0x8cc95dc98eb5bc94 => 36
	i64 10229024438826829339, ; 81: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 18
	i64 10321854143672141184, ; 82: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 63
	i64 10430153318873392755, ; 83: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 16
	i64 10577027937037808856, ; 84: AngleSharp => 0x92c926de868574d8 => 35
	i64 11023048688141570732, ; 85: System.Core => 0x98f9bc61168392ac => 6
	i64 11037814507248023548, ; 86: System.Xml => 0x992e31d0412bf7fc => 10
	i64 11122995063473561350, ; 87: Xamarin.CommunityToolkit.dll => 0x9a5cd113fcc3df06 => 50
	i64 11162124722117608902, ; 88: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 28
	i64 11340910727871153756, ; 89: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 17
	i64 11529969570048099689, ; 90: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 28
	i64 11601420967407813619, ; 91: News_aggregator.Android.dll => 0xa10086e7241c83f3 => 64
	i64 11739066727115742305, ; 92: SQLite-net.dll => 0xa2e98afdf8575c61 => 40
	i64 11806260347154423189, ; 93: SQLite-net => 0xa3d8433bc5eb5d95 => 40
	i64 12102847907131387746, ; 94: System.Buffers => 0xa7f5f40c43256f62 => 5
	i64 12269460666702402136, ; 95: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 45
	i64 12279246230491828964, ; 96: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 44
	i64 12451044538927396471, ; 97: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 20
	i64 12466513435562512481, ; 98: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 25
	i64 12538491095302438457, ; 99: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 14
	i64 12963446364377008305, ; 100: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 32
	i64 13370592475155966277, ; 101: System.Runtime.Serialization => 0xb98de304062ea945 => 1
	i64 13454009404024712428, ; 102: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 60
	i64 13572454107664307259, ; 103: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 26
	i64 13647894001087880694, ; 104: System.Data.dll => 0xbd670f48cb071df6 => 31
	i64 13959074834287824816, ; 105: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 20
	i64 13967638549803255703, ; 106: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 57
	i64 14124974489674258913, ; 107: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 14
	i64 14165531176311179688, ; 108: Xamarin.Firebase.Auth => 0xc496138d7abfc9a8 => 52
	i64 14382082037123372364, ; 109: Xamarin.Firebase.Auth.Interop => 0xc7976b69c943d54c => 53
	i64 14789919016435397935, ; 110: Xamarin.Firebase.Common.dll => 0xcd4058fc2f6d352f => 54
	i64 14792063746108907174, ; 111: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 60
	i64 14852515768018889994, ; 112: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 17
	i64 14935719434541007538, ; 113: System.Text.Encoding.CodePages.dll => 0xcf4655b160b702b2 => 33
	i64 15370334346939861994, ; 114: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 16
	i64 15609085926864131306, ; 115: System.dll => 0xd89e9cf3334914ea => 7
	i64 15810740023422282496, ; 116: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 59
	i64 15930129725311349754, ; 117: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 62
	i64 16154507427712707110, ; 118: System => 0xe03056ea4e39aa26 => 7
	i64 16755018182064898362, ; 119: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 42
	i64 16833383113903931215, ; 120: mscorlib => 0xe99c30c1484d7f4f => 4
	i64 17704177640604968747, ; 121: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 25
	i64 17710060891934109755, ; 122: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 24
	i64 17827832363535584534, ; 123: Xamarin.Forms.PancakeView.dll => 0xf7692f1427c04d16 => 56
	i64 17838668724098252521, ; 124: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 5
	i64 17882897186074144999, ; 125: FormsViewGroup => 0xf82cd03e3ac830e7 => 37
	i64 17891337867145587222, ; 126: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 63
	i64 17892495832318972303, ; 127: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 59
	i64 17986907704309214542, ; 128: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 61
	i64 18129453464017766560, ; 129: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 30
	i64 18370042311372477656, ; 130: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 43
	i64 18439108438687598470 ; 131: System.Reflection.Metadata.dll => 0xffe4df6e2ee1c786 => 47
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [132 x i32] [
	i32 3, i32 49, i32 35, i32 46, i32 32, i32 21, i32 43, i32 19, ; 0..7
	i32 58, i32 34, i32 29, i32 42, i32 53, i32 1, i32 44, i32 12, ; 8..15
	i32 39, i32 13, i32 49, i32 24, i32 50, i32 39, i32 19, i32 23, ; 16..23
	i32 9, i32 15, i32 48, i32 65, i32 10, i32 4, i32 9, i32 55, ; 24..31
	i32 29, i32 22, i32 54, i32 61, i32 27, i32 8, i32 26, i32 65, ; 32..39
	i32 62, i32 41, i32 30, i32 48, i32 27, i32 57, i32 51, i32 64, ; 40..47
	i32 56, i32 6, i32 58, i32 37, i32 41, i32 23, i32 52, i32 18, ; 48..55
	i32 33, i32 21, i32 11, i32 11, i32 46, i32 55, i32 51, i32 0, ; 56..63
	i32 31, i32 12, i32 22, i32 2, i32 45, i32 2, i32 36, i32 38, ; 64..71
	i32 38, i32 13, i32 8, i32 15, i32 3, i32 47, i32 34, i32 0, ; 72..79
	i32 36, i32 18, i32 63, i32 16, i32 35, i32 6, i32 10, i32 50, ; 80..87
	i32 28, i32 17, i32 28, i32 64, i32 40, i32 40, i32 5, i32 45, ; 88..95
	i32 44, i32 20, i32 25, i32 14, i32 32, i32 1, i32 60, i32 26, ; 96..103
	i32 31, i32 20, i32 57, i32 14, i32 52, i32 53, i32 54, i32 60, ; 104..111
	i32 17, i32 33, i32 16, i32 7, i32 59, i32 62, i32 7, i32 42, ; 112..119
	i32 4, i32 25, i32 24, i32 56, i32 5, i32 37, i32 63, i32 59, ; 120..127
	i32 61, i32 30, i32 43, i32 47 ; 128..131
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
