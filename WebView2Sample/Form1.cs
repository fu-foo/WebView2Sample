using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;


namespace Fu.WebView2Sample
{
    /// <summary>
    /// 最低限のWebView2サンプル(yahoo.co.jpを開く→検索文字列をセット→検索）
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// フォーム初期化
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            InitializeWebView2();
        }

        /// <summary>
        /// WebView2初期化
        /// </summary>
        async void InitializeWebView2()
        {
            // WebView2の初期処理確認
            await this.webView2.EnsureCoreWebView2Async(null);

            // Yahoo検索画面
            this.webView2.CoreWebView2.Navigate("https://yahoo.co.jp");

            // 遷移完了のイベント追加
            this.webView2.CoreWebView2.NavigationCompleted += this.webView2_NavigationCompleted;
        }

        /// <summary>
        /// 遷移完了後の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                // 検索文字列に"C#"をセット
                this.webView2.ExecuteScriptAsync("document.getElementsByName('p').item(0).value = 'C#';");
                // submit
                this.webView2.ExecuteScriptAsync("document.getElementsByName('sf1').item(0).submit();");
            }
            else
            {
                // エラー処理
            }
        }
    }
}
