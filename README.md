# Redis_COM

##Summary
<b>[StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)</b> COM Interface wrapper library. 
Usage is same as StackExchange.Redis.
Let's Redis access from VBA and VB! 

##Building
Redis_COM.sln open in a Visual Studio Administrator mode,
Please install the StackExchange.Redis to developement enviroment from the Nuget.
Let's Build!

How to Nuget Package Manager Console :

```
PM> Install-Package StackExchange.Redis
```

##How to Use
After Redis_COM builded or Installed, Redis_COM COM library add to VBE References libraries dialog.<br>
Set enable Redis_COM library in References libraryies dialog.<br>
![vba_references](https://cloud.githubusercontent.com/assets/9222089/21329816/06bcd2ce-c67e-11e6-81a3-062daff8b573.png)
<br>
<br>

<hr>

<br>
##概要
<b>[StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)</b>をCOMインターフェース用にラップしたライブラリです。<br>
基本的な使用方法はStackExchange.Redisに倣います。<br>
<b>VB,VBA</b>などのコードから直接Redisを利用できるようになります。<br>
<br>

##ビルド方法
Redis_COM.slnを管理者権限で実行したVisualStudioで開き、NugetでStackExchange.Redisを開発環境に加えた後ビルドしてください。<br>
<br>
Nuget パッケージマネージャーコンソールでの追加方法

```
PM> Install-Package StackExchange.Redis
```
##使用方法
VBAの場合、正常にインストール、もしくはビルドに成功した場合、VBEの環境設定に`Redis_COM`が追加されています。<br>
`Redis_COM`を有効にすればVBAでRedisアクセスができるようになります。<br>
![vba_references](https://cloud.githubusercontent.com/assets/9222089/21329816/06bcd2ce-c67e-11e6-81a3-062daff8b573.png)

<br>
基本的な使用方法はStackExchange.Redisと全く同じです。StackExchange.RedisのDocumentがそのまま本ライブラリのドキュメントになります。<br>
<br>実際に使用しているサンプルコードが<b>exmaples</b>ディレクトリにあります。参考にしてください。<br>
