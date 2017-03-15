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

＜改善点＞
・オブジェクト指向から外れたプログラミングを行っている為、全てのクラスのリファクタリングを行う。
・フィールド変数にアンダーバーを付ける。
・マジックナンバーを取り入れる。
・ドリルに用いるクラスにIEnumeratorを使う。
・メソッド名が抽象的なものが多いので、具体的な名前に変更する。
