# Redis_COM

##概要
<b>[StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)</b>をCOMインターフェース用にラップしたライブラリです。<br>
基本的な使用方法はStackExchange.Redisに倣います。<br>

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


基本的な使用方法はStackExchange.Redisと全く同じです。StackExchange.RedisのDocumentがそのまま本ライブラリのドキュメントになります。<br>
<br>実際に使用しているサンプルコードが<b>exmaples</b>ディレクトリにあります。参考にしてください。<br>
