オブジェクト指向プログラム
RadioButtonUI
	ラジオボタンの働きを行う。
ButtonUI
	ボタンとしての働きを行う。

GenerateManager
	パネルの生成を行う。
Blueprint
	アイテム生成に必要な情報や素材の情報を登録と読み込みをする。
StatumGenerator : Blueprint
	Blueprintで登録した情報を使い、地層パネルの生成を行う。
ItemGenerator : Blueprint
	Blueprintで登録した情報を使い、アイテムパネルの生成をおこなう。

Tool
	道具に必要な情報の登録と読み込みができる。
ToolPickaxe : Tool
	つるはしに必要な動きをToolを継承して製作されている。
ToolHummer : Tool
	ハンマーに必要な動きをToolを継承して製作されている。
ToolDorill : Tool
	ドリルに必要な動きをToolを継承して製作されている。

今後の展開
・開発中のボムをストック性にし、掘り当てると使用できるようにする機能の手直し（オブジェクト指向プログラミングを用いて直す）
・Hitpointのプログラムの修正（オブジェクト指向に基づいて各機能を個々のクラスに分けたコーディングする）
・使われていない不要なクラスの削除
・public が付いているフィールド変数を全てprivateに変更し、[SerializeField]をつける
・FindJewelryのプログラムの修正（コーディング量の削減）