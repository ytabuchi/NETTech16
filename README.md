# .NET 開発テクノロジ入門 2016年版 Xamarin の章のサンプルプロジェクトです。

## ダウンロード後の手順

zip をダウンロードするか［Clone］して適当なフォルダに展開して`HelloXamarinForms.sln`を開きます。  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/01%20Open.png" width="450" />

ソリューションフォルダを右クリックして、［NeGetパッケージの復元］をクリックします。  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/02%20Restore%20NuGet%20Package.png" width="450" />

復元が完了しても、`HelloXamarinForms`プロジェクトの［参照］から［！］アイコンが消えないので、ファイルをクリックして［！］を消します。  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/03-1%20Click%20restored%20package.png" width="300" /> <img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/03-2%20Click%20restored%20package.png" width="300" />

PCLの`HelloXamarinForms`プロジェクトをビルドしておきます。では上から順番にビルドしていきます。`HelloXamarinForms.Android`プロジェクトを右クリックして、［スタートアッププロジェクトに設定］をクリックします。

エラーが大量に発生することがありますが、ビルドすると消えるはずです。  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/04%20Android.png" width="450" />

Androidをビルドできました。  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/04-1%20Android%20screenshot.png" width="300" />

続いてiOSプロジェクトもビルドしてみましょう。  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/05%20iOS%20screenshot.png" width="300" />

UWPプロジェクトをビルドします。各種環境で動作しているのが分かります。  
Windows 10 デスクトップでの実行  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/06-1%20UWP%20Windows%2010%20Desktop%20screenshot.png" width="300" />  

UWPプロジェクトで［証明書ファイル 'HelloXamarinForms.UWP_TemporaryKey.pfx' が見つかりません］というエラーが表示されます。無視してもビルドは出来るようですが、気になる場合は、別のUWPプロジェクトを作成し、自動生成された`pfx`ファイルをUWPプロジェクトフォルダにコピーして、ファイル名を`HelloXamarinForms.UWP_TemporaryKey.pfx`に合わせてビルドしなおしてください。
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/07%20UWP%20key.png" width="300" />

Windows 10の環境でビルドが出来ない場合は、［リモートデバッグ］を使用してネットワーク上のWindows 10タブレットなどに配布することができます。

まずは配布対象のWindows 10マシンに [Remote Tools for Visual Studio 2015 Update 1](https://www.microsoft.com/ja-jp/download/details.aspx?id=49986) をダウンロード、インストールし、［ツール］－［オプション］から［認証なし］を選択して、待ち受け状態にしておきます。  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/08-1%20Remote%20Debugger%20Tool.png" width="300" />  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/08-2%20Remote%20Debugger%20Tool.png" width="300" />  

ビルド元のVisual Studioのメニューから［デバッグ］－［XXXのプロパティ］をクリックします。
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/08-3%20Remote%20Debug.png" width="300" />

［ターゲットデバイス］を［リモートコンピューター］にして、［検索］ボタンをクリックします。
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/08-4%20Remote%20Debug.png" width="450" />

リストされたマシンから対象マシンを選択し、ビルドしてみましょう。Windows 10 Mobile端末を持っていれば、USBで接続してビルドすることもできます。
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/08-5%20Remote%20Debug.png" width="450" />  

Windows 10 タブレット（タブレットモード）での実行  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/06-2%20Windows10%20Tablet%20screenshot.png" width="300" />  
Windows 10 Mobileでの実行  
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/06-3%20Windows10%20Mobile%20screenshot.png" width="300" />


次はWindows81プロジェクトでストアアプリをビルドしてみましょう。
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/09%20Windows%20Store%20screenshot.png" width="450" />

最後にWindows Phone 8.0（Sliverlight）プロジェクトと、Windows Phone 8.1（WinRT）をビルドしてみましょう。
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/10%20WP8%20Silverlight.png" width="300" />
<img src="https://github.com/ytabuchi/NETTech16/blob/master/Screenshots/11%20WP81%20WinRT.png" width="300" />

Xamarin.FormsでiOS／Android／UWP／Windows Phone／Windows Storeの様々なOSにアプリが作成できるのがお分かりいただけるかと思います。

以上です。


