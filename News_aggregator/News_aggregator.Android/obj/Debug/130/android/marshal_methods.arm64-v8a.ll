; ModuleID = 'obj\Debug\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.arm64-v8a.ll"
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
@assembly_image_cache_hashes = local_unnamed_addr constant [228 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 57
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 9
	i64 210515253464952879, ; 2: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 47
	i64 232391251801502327, ; 3: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 79
	i64 295915112840604065, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 80
	i64 376821212072123757, ; 5: AngleSharp.dll => 0x53abce559641d6d => 4
	i64 464346026994987652, ; 6: System.Reactive.dll => 0x671b04057e67284 => 25
	i64 634308326490598313, ; 7: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 66
	i64 687654259221141486, ; 8: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 98
	i64 702024105029695270, ; 9: System.Drawing.Common => 0x9be17343c0e7726 => 107
	i64 720058930071658100, ; 10: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 60
	i64 870603111519317375, ; 11: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 16
	i64 872800313462103108, ; 12: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 56
	i64 940822596282819491, ; 13: System.Transactions => 0xd0e792aa81923a3 => 105
	i64 996343623809489702, ; 14: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 94
	i64 1000557547492888992, ; 15: Mono.Security.dll => 0xde2b1c9cba651a0 => 113
	i64 1120440138749646132, ; 16: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 96
	i64 1301485588176585670, ; 17: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 15
	i64 1315114680217950157, ; 18: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 42
	i64 1342439039765371018, ; 19: Xamarin.Android.Support.Fragment => 0x12a14d31b1d4d88a => 35
	i64 1425944114962822056, ; 20: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 3
	i64 1518315023656898250, ; 21: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 17
	i64 1624659445732251991, ; 22: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 40
	i64 1628611045998245443, ; 23: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 68
	i64 1636321030536304333, ; 24: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 61
	i64 1731380447121279447, ; 25: Newtonsoft.Json => 0x18071957e9b889d7 => 12
	i64 1743969030606105336, ; 26: System.Memory.dll => 0x1833d297e88f2af8 => 22
	i64 1795316252682057001, ; 27: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 41
	i64 1836611346387731153, ; 28: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 79
	i64 1875917498431009007, ; 29: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 38
	i64 1981742497975770890, ; 30: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 67
	i64 2133195048986300728, ; 31: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 12
	i64 2136356949452311481, ; 32: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 72
	i64 2165725771938924357, ; 33: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 45
	i64 2262844636196693701, ; 34: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 56
	i64 2284400282711631002, ; 35: System.Web.Services => 0x1fb3d1f42fd4249a => 111
	i64 2329709569556905518, ; 36: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 64
	i64 2337758774805907496, ; 37: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 27
	i64 2470498323731680442, ; 38: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 51
	i64 2479423007379663237, ; 39: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 84
	i64 2497223385847772520, ; 40: System.Runtime => 0x22a7eb7046413568 => 28
	i64 2547086958574651984, ; 41: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 37
	i64 2549645802113351205, ; 42: News_aggregator => 0x2362295932083e25 => 11
	i64 2592350477072141967, ; 43: System.Xml.dll => 0x23f9e10627330e8f => 29
	i64 2624866290265602282, ; 44: mscorlib.dll => 0x246d65fbde2db8ea => 10
	i64 2694427813909235223, ; 45: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 76
	i64 2783046991838674048, ; 46: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 27
	i64 2960931600190307745, ; 47: Xamarin.Forms.Core => 0x2917579a49927da1 => 92
	i64 3017704767998173186, ; 48: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 96
	i64 3022227708164871115, ; 49: Xamarin.Android.Support.Media.Compat.dll => 0x29f11c168f8293cb => 36
	i64 3289520064315143713, ; 50: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 63
	i64 3303437397778967116, ; 51: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 39
	i64 3311221304742556517, ; 52: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 24
	i64 3364695309916733813, ; 53: Xamarin.Firebase.Common => 0x2eb1cc8eb5028175 => 91
	i64 3411255996856937470, ; 54: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 99
	i64 3493805808809882663, ; 55: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 82
	i64 3522470458906976663, ; 56: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 81
	i64 3531994851595924923, ; 57: System.Numerics => 0x31042a9aade235bb => 23
	i64 3571415421602489686, ; 58: System.Runtime.dll => 0x319037675df7e556 => 28
	i64 3716579019761409177, ; 59: netstandard.dll => 0x3393f0ed5c8c5c99 => 103
	i64 3727469159507183293, ; 60: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 78
	i64 3772598417116884899, ; 61: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 57
	i64 3966267475168208030, ; 62: System.Memory => 0x370b03412596249e => 22
	i64 3978647773165252022, ; 63: News_aggregator.dll => 0x3736ff11e5e9edb6 => 11
	i64 4247996603072512073, ; 64: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 100
	i64 4337444564132831293, ; 65: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 14
	i64 4525561845656915374, ; 66: System.ServiceModel.Internals => 0x3ece06856b710dae => 102
	i64 4636684751163556186, ; 67: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 86
	i64 4782108999019072045, ; 68: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 44
	i64 4794310189461587505, ; 69: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 37
	i64 4795410492532947900, ; 70: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 81
	i64 5142919913060024034, ; 71: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 93
	i64 5203618020066742981, ; 72: Xamarin.Essentials => 0x4836f704f0e652c5 => 89
	i64 5205316157927637098, ; 73: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 70
	i64 5312372435986440853, ; 74: News_aggregator.Android => 0x49b95695998c6295 => 0
	i64 5348796042099802469, ; 75: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 71
	i64 5376510917114486089, ; 76: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 84
	i64 5408338804355907810, ; 77: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 83
	i64 5451019430259338467, ; 78: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 50
	i64 5507995362134886206, ; 79: System.Core.dll => 0x4c705499688c873e => 20
	i64 5692067934154308417, ; 80: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 88
	i64 5757522595884336624, ; 81: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 48
	i64 5767696078500135884, ; 82: Xamarin.Android.Support.Annotations.dll => 0x500af9065b6a03cc => 31
	i64 5814345312393086621, ; 83: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 76
	i64 5896680224035167651, ; 84: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 65
	i64 6085203216496545422, ; 85: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 94
	i64 6086316965293125504, ; 86: FormsViewGroup.dll => 0x5476f10882baef80 => 6
	i64 6183170893902868313, ; 87: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 14
	i64 6319713645133255417, ; 88: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 66
	i64 6401687960814735282, ; 89: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 64
	i64 6403742896930319886, ; 90: Xamarin.Firebase.Auth.dll => 0x58deaa3c7c766e0e => 90
	i64 6504860066809920875, ; 91: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 45
	i64 6548213210057960872, ; 92: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 54
	i64 6591024623626361694, ; 93: System.Web.Services.dll => 0x5b7805f9751a1b5e => 111
	i64 6617685658146568858, ; 94: System.Text.Encoding.CodePages => 0x5bd6be0b4905fa9a => 112
	i64 6659513131007730089, ; 95: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 60
	i64 6876862101832370452, ; 96: System.Xml.Linq => 0x5f6f85a57d108914 => 30
	i64 6894844156784520562, ; 97: System.Numerics.Vectors => 0x5faf683aead1ad72 => 24
	i64 7036436454368433159, ; 98: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 62
	i64 7103753931438454322, ; 99: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 59
	i64 7141577505875122296, ; 100: System.Runtime.InteropServices.WindowsRuntime.dll => 0x631bfae7659b5878 => 1
	i64 7488575175965059935, ; 101: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 30
	i64 7602111570124318452, ; 102: System.Reactive => 0x698020320025a6f4 => 25
	i64 7635363394907363464, ; 103: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 92
	i64 7637365915383206639, ; 104: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 89
	i64 7654504624184590948, ; 105: System.Net.Http => 0x6a3a4366801b8264 => 2
	i64 7820441508502274321, ; 106: System.Data => 0x6c87ca1e14ff8111 => 104
	i64 7836164640616011524, ; 107: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 40
	i64 8044118961405839122, ; 108: System.ComponentModel.Composition => 0x6fa2739369944712 => 110
	i64 8083354569033831015, ; 109: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 63
	i64 8101777744205214367, ; 110: Xamarin.Android.Support.Annotations => 0x706f4beeec84729f => 31
	i64 8103644804370223335, ; 111: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 106
	i64 8167236081217502503, ; 112: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 7
	i64 8398329775253868912, ; 113: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 49
	i64 8400357532724379117, ; 114: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 75
	i64 8518412311883997971, ; 115: System.Collections.Immutable => 0x76377add7c28e313 => 19
	i64 8601935802264776013, ; 116: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 83
	i64 8626175481042262068, ; 117: Java.Interop => 0x77b654e585b55834 => 7
	i64 8639588376636138208, ; 118: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 74
	i64 8684531736582871431, ; 119: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 109
	i64 8702320156596882678, ; 120: Firebase.dll => 0x78c4da1357adccf6 => 5
	i64 9057635389615298436, ; 121: LiteDB => 0x7db32f65bf06d784 => 8
	i64 9296667808972889535, ; 122: LiteDB.dll => 0x8104661dcca35dbf => 8
	i64 9312692141327339315, ; 123: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 88
	i64 9324707631942237306, ; 124: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 41
	i64 9662334977499516867, ; 125: System.Numerics.dll => 0x8617827802b0cfc3 => 23
	i64 9678050649315576968, ; 126: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 51
	i64 9711637524876806384, ; 127: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 71
	i64 9808709177481450983, ; 128: Mono.Android.dll => 0x881f890734e555e7 => 9
	i64 9825649861376906464, ; 129: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 48
	i64 9834056768316610435, ; 130: System.Transactions.dll => 0x8879968718899783 => 105
	i64 9836529246295212050, ; 131: System.Reflection.Metadata => 0x88825f3bbc2ac012 => 26
	i64 9875200773399460291, ; 132: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 98
	i64 9998632235833408227, ; 133: Mono.Security => 0x8ac2470b209ebae3 => 113
	i64 10038780035334861115, ; 134: System.Net.Http.dll => 0x8b50e941206af13b => 2
	i64 10144742755892837524, ; 135: Firebase => 0x8cc95dc98eb5bc94 => 5
	i64 10229024438826829339, ; 136: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 54
	i64 10321854143672141184, ; 137: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 101
	i64 10376576884623852283, ; 138: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 82
	i64 10430153318873392755, ; 139: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 52
	i64 10577027937037808856, ; 140: AngleSharp => 0x92c926de868574d8 => 4
	i64 10847732767863316357, ; 141: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 42
	i64 11023048688141570732, ; 142: System.Core => 0x98f9bc61168392ac => 20
	i64 11037814507248023548, ; 143: System.Xml => 0x992e31d0412bf7fc => 29
	i64 11162124722117608902, ; 144: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 87
	i64 11340910727871153756, ; 145: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 53
	i64 11376461258732682436, ; 146: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 32
	i64 11392833485892708388, ; 147: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 77
	i64 11529969570048099689, ; 148: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 87
	i64 11578238080964724296, ; 149: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 62
	i64 11580057168383206117, ; 150: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 38
	i64 11597940890313164233, ; 151: netstandard => 0xa0f429ca8d1805c9 => 103
	i64 11601420967407813619, ; 152: News_aggregator.Android.dll => 0xa10086e7241c83f3 => 0
	i64 11672361001936329215, ; 153: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 59
	i64 11739066727115742305, ; 154: SQLite-net.dll => 0xa2e98afdf8575c61 => 13
	i64 11806260347154423189, ; 155: SQLite-net => 0xa3d8433bc5eb5d95 => 13
	i64 12102847907131387746, ; 156: System.Buffers => 0xa7f5f40c43256f62 => 18
	i64 12137774235383566651, ; 157: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 85
	i64 12269460666702402136, ; 158: System.Collections.Immutable.dll => 0xaa45e178506c9258 => 19
	i64 12279246230491828964, ; 159: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 17
	i64 12414299427252656003, ; 160: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 32
	i64 12451044538927396471, ; 161: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 58
	i64 12466513435562512481, ; 162: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 69
	i64 12487638416075308985, ; 163: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 55
	i64 12538491095302438457, ; 164: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 46
	i64 12550732019250633519, ; 165: System.IO.Compression => 0xae2d28465e8e1b2f => 108
	i64 12700543734426720211, ; 166: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 47
	i64 12952608645614506925, ; 167: Xamarin.Android.Support.Core.Utils => 0xb3c0e8eff48193ad => 34
	i64 12963446364377008305, ; 168: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 107
	i64 13358059602087096138, ; 169: Xamarin.Android.Support.Fragment.dll => 0xb9615c6f1ee5af4a => 35
	i64 13370592475155966277, ; 170: System.Runtime.Serialization => 0xb98de304062ea945 => 3
	i64 13401370062847626945, ; 171: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 85
	i64 13404347523447273790, ; 172: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 49
	i64 13454009404024712428, ; 173: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 97
	i64 13491513212026656886, ; 174: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 43
	i64 13572454107664307259, ; 175: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 78
	i64 13647894001087880694, ; 176: System.Data.dll => 0xbd670f48cb071df6 => 104
	i64 13959074834287824816, ; 177: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 58
	i64 13967638549803255703, ; 178: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 93
	i64 14124974489674258913, ; 179: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 46
	i64 14165531176311179688, ; 180: Xamarin.Firebase.Auth => 0xc496138d7abfc9a8 => 90
	i64 14172845254133543601, ; 181: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 72
	i64 14261073672896646636, ; 182: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 77
	i64 14400856865250966808, ; 183: Xamarin.Android.Support.Core.UI => 0xc7da1f051a877d18 => 33
	i64 14486659737292545672, ; 184: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 65
	i64 14644440854989303794, ; 185: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 70
	i64 14789919016435397935, ; 186: Xamarin.Firebase.Common.dll => 0xcd4058fc2f6d352f => 91
	i64 14792063746108907174, ; 187: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 97
	i64 14852515768018889994, ; 188: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 53
	i64 14935719434541007538, ; 189: System.Text.Encoding.CodePages.dll => 0xcf4655b160b702b2 => 112
	i64 14987728460634540364, ; 190: System.IO.Compression.dll => 0xcfff1ba06622494c => 108
	i64 14988210264188246988, ; 191: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 55
	i64 15370334346939861994, ; 192: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 52
	i64 15457813392950723921, ; 193: Xamarin.Android.Support.Media.Compat => 0xd6852f61c31a8551 => 36
	i64 15582737692548360875, ; 194: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 68
	i64 15609085926864131306, ; 195: System.dll => 0xd89e9cf3334914ea => 21
	i64 15777549416145007739, ; 196: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 80
	i64 15810740023422282496, ; 197: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 95
	i64 15930129725311349754, ; 198: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 100
	i64 16154507427712707110, ; 199: System => 0xe03056ea4e39aa26 => 21
	i64 16565028646146589191, ; 200: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 110
	i64 16621146507174665210, ; 201: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 50
	i64 16677317093839702854, ; 202: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 75
	i64 16755018182064898362, ; 203: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 15
	i64 16822611501064131242, ; 204: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 106
	i64 16833383113903931215, ; 205: mscorlib => 0xe99c30c1484d7f4f => 10
	i64 16866861824412579935, ; 206: System.Runtime.InteropServices.WindowsRuntime => 0xea132176ffb5785f => 1
	i64 16932527889823454152, ; 207: Xamarin.Android.Support.Core.Utils.dll => 0xeafc6c67465253c8 => 34
	i64 17024911836938395553, ; 208: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 39
	i64 17031351772568316411, ; 209: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 73
	i64 17037200463775726619, ; 210: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 61
	i64 17428701562824544279, ; 211: Xamarin.Android.Support.Core.UI.dll => 0xf1df2fbaec73d017 => 33
	i64 17544493274320527064, ; 212: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 44
	i64 17704177640604968747, ; 213: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 69
	i64 17710060891934109755, ; 214: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 67
	i64 17838668724098252521, ; 215: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 18
	i64 17882897186074144999, ; 216: FormsViewGroup => 0xf82cd03e3ac830e7 => 6
	i64 17891337867145587222, ; 217: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 101
	i64 17892495832318972303, ; 218: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 95
	i64 17928294245072900555, ; 219: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 109
	i64 17986907704309214542, ; 220: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 99
	i64 18116111925905154859, ; 221: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 43
	i64 18121036031235206392, ; 222: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 73
	i64 18129453464017766560, ; 223: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 102
	i64 18305135509493619199, ; 224: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 74
	i64 18370042311372477656, ; 225: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 16
	i64 18380184030268848184, ; 226: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 86
	i64 18439108438687598470 ; 227: System.Reflection.Metadata.dll => 0xffe4df6e2ee1c786 => 26
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [228 x i32] [
	i32 57, i32 9, i32 47, i32 79, i32 80, i32 4, i32 25, i32 66, ; 0..7
	i32 98, i32 107, i32 60, i32 16, i32 56, i32 105, i32 94, i32 113, ; 8..15
	i32 96, i32 15, i32 42, i32 35, i32 3, i32 17, i32 40, i32 68, ; 16..23
	i32 61, i32 12, i32 22, i32 41, i32 79, i32 38, i32 67, i32 12, ; 24..31
	i32 72, i32 45, i32 56, i32 111, i32 64, i32 27, i32 51, i32 84, ; 32..39
	i32 28, i32 37, i32 11, i32 29, i32 10, i32 76, i32 27, i32 92, ; 40..47
	i32 96, i32 36, i32 63, i32 39, i32 24, i32 91, i32 99, i32 82, ; 48..55
	i32 81, i32 23, i32 28, i32 103, i32 78, i32 57, i32 22, i32 11, ; 56..63
	i32 100, i32 14, i32 102, i32 86, i32 44, i32 37, i32 81, i32 93, ; 64..71
	i32 89, i32 70, i32 0, i32 71, i32 84, i32 83, i32 50, i32 20, ; 72..79
	i32 88, i32 48, i32 31, i32 76, i32 65, i32 94, i32 6, i32 14, ; 80..87
	i32 66, i32 64, i32 90, i32 45, i32 54, i32 111, i32 112, i32 60, ; 88..95
	i32 30, i32 24, i32 62, i32 59, i32 1, i32 30, i32 25, i32 92, ; 96..103
	i32 89, i32 2, i32 104, i32 40, i32 110, i32 63, i32 31, i32 106, ; 104..111
	i32 7, i32 49, i32 75, i32 19, i32 83, i32 7, i32 74, i32 109, ; 112..119
	i32 5, i32 8, i32 8, i32 88, i32 41, i32 23, i32 51, i32 71, ; 120..127
	i32 9, i32 48, i32 105, i32 26, i32 98, i32 113, i32 2, i32 5, ; 128..135
	i32 54, i32 101, i32 82, i32 52, i32 4, i32 42, i32 20, i32 29, ; 136..143
	i32 87, i32 53, i32 32, i32 77, i32 87, i32 62, i32 38, i32 103, ; 144..151
	i32 0, i32 59, i32 13, i32 13, i32 18, i32 85, i32 19, i32 17, ; 152..159
	i32 32, i32 58, i32 69, i32 55, i32 46, i32 108, i32 47, i32 34, ; 160..167
	i32 107, i32 35, i32 3, i32 85, i32 49, i32 97, i32 43, i32 78, ; 168..175
	i32 104, i32 58, i32 93, i32 46, i32 90, i32 72, i32 77, i32 33, ; 176..183
	i32 65, i32 70, i32 91, i32 97, i32 53, i32 112, i32 108, i32 55, ; 184..191
	i32 52, i32 36, i32 68, i32 21, i32 80, i32 95, i32 100, i32 21, ; 192..199
	i32 110, i32 50, i32 75, i32 15, i32 106, i32 10, i32 1, i32 34, ; 200..207
	i32 39, i32 73, i32 61, i32 33, i32 44, i32 69, i32 67, i32 18, ; 208..215
	i32 6, i32 101, i32 95, i32 109, i32 99, i32 43, i32 73, i32 102, ; 216..223
	i32 74, i32 16, i32 86, i32 26 ; 224..227
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
