using System.Diagnostics;
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

            // WebView2初期化完了イベント追加
            this.webView2.CoreWebView2InitializationCompleted += this.WebView2InitializationCompleted;

            // WebView2初期化完了確認
            this.webView2.EnsureCoreWebView2Async(null);
        }

        /// <summary>
        /// WebView2初期化完了イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                // Yahoo検索画面
                this.webView2.CoreWebView2.Navigate("https://url_you_wanna_go");

                // 遷移完了のイベント追加
                this.webView2.CoreWebView2.NavigationCompleted += this.webView2_NavigationCompleted;
            }
            else
            {
                // エラー処理
            }
        }

        /// <summary>
        /// 遷移完了後イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                // 実行したいJavaSciprtを記載　※サンプル：name:pppppのタグに"C#"の文字列をセット
                this.webView2.ExecuteScriptAsync("document.getElementsByName('ppppp').item(0).value = 'C#';");
            }
            else
            {
                // エラー処理
            }
        }
    }
}
