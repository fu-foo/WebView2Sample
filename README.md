# 初めに

WebView2を最低限動かすためのサンプルです。

- WebView2 初期化
- WebView2 URL指定で遷移
- WebView2 でJavaScript実行

を行うサンプルです。

# 環境

OS:Windows10 バージョン21H2
開発環境:Visual Studio 2022 Enterprise (※大したことはしてないのでCommunity Editionでも動くと思います。）
.Net Framework4.6 + Windows Forms で今回は作成。

# 使い方

- ソース内"https://url_you_wanna_go"部分を書き換え
- ソース内ExecuteScriptAsyncに記載されているJavaScript書き換え

を行ってビルド～実行してください。

# 「参照コンポーネント 'System' が見つかりませんでした。」が出る場合。

NuGetあるあるなので、こちらで対応お願いします。

https://final.hateblo.jp/entry/2015/12/29/182850

# その他

最低限の実装なので実際に使用する際はエラー処理を追加するなど配慮が必要です。
