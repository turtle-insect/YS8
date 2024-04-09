![DL Count](https://img.shields.io/github/downloads/turtle-insect/YS8/total.svg)

# 概要
Switch YS8(イース8)のセーブデータ編集Tool

# ソフト
https://nippon1.jp/consumer/ys8_switch/

# 実行に必要
* Windows マシン
* .NET Framework 4.8の導入
* セーブデータの吸い出し
* セーブデータの書き戻し

# Build環境
* Windows 10(64bit)
* Visual Studio 2017

# 編集時の手順
* saveDataを吸い出す
   * 結果、以下が取得可能
      * data0001 - data0061のフォルダ
         * icon0.png
         * info.txt
         * SAVEDATA.DAT
* SAVEDATA.DATを読み込む
* 任意の編集を行う
* SAVEDATA.DATを書き出す
* saveDataを書き戻す
