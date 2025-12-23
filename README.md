# robosys2025
都市間距離計測コマンド
=====
- distance [![distance](https://github.com/leo0607y/robosys2025/actions/workflows/distance.yml/badge.svg)](https://github.com/leo0607y/robosys2025/actions/workflows/distance.yml)
    - 都市間（都市でなくても駅になってる地名位までならいける）の距離が気になって仕方なくなったら使えるコマンド

## 実験環境
- Ubuntu-22.04
- インターネットにつながる環境

## 使用ソフト
- Python (3.8~.12までテストにより動作確認済み)

## 使用方法
### リポジトリのクローン

```shell
$ git clone https://github.com/leo0607y/robosys2025.git
$ cd robosys2025
```

### セットアップ
    仮想環境を構築し有効化する。必要ライブラリをインストールする。
```shell
$ python3 -m venv venv
$ source venv/bin/activate
$ pip install geopy
$ chmod +x distance #初回のみ必須
```
### distance:使用方法
```shell
$ ./distance
```
- START：と表示されるので英語またはローマ字で日本の地名を入力
- GOAL:と表示されるので同様に入力。
- 入力された内容に基づいて緯度経度を表示し、直線距離を計算。
- km及びmilesで表示する。

### 使用例
```shell
$ ./distance

```

## 著作及びライセンス
- このソフトウェアパッケージは、３条項BSDライセンスの下、再頒布及び仕様が許可されます。
- このソフトウェアは、サードパーティ製のライブラリとして **[geopy](https://github.com/geopy/geopy)** を利用しています。geopyは MIT License の下でライセンスされています（ライセンス条文の全文は [NOTICE.md](NOTICE.md) を参照）。
- © 2025 Reo Yamaguchi

