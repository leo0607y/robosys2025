#!/bin/bash -xv
#SPDX-FileCopyrightText: 2025 Reo Yamaguchi reo.yamaguchi0607@gmail.com
#SPDX-License-Identifier: BSD-3-Clause

ng (){
    echo "${1}行目で失敗"
    res=1
}

res=0

### 通常動作 ###
# スラッシュ区切り入力、終了ステータス＝０
out=$(echo "Tokyo/Osaka" | ./distance)
[ "$?" = 0 ] || ng "$LINENO"

# 出力確認
line_count=$(echo "${out}" | wc -l)
[ "${line_count}" = 2 ] || ng "$LINENO"

# 出力が数値かを確認
echo "${out}" | head -n 1 | grep -qE '^[0-9.]+$' || ng "$LINENO"

### 実在しない地名 ###
echo "kitagami/takiase" | ./distance
[ "$?" = 1 ] || ng "$LINENO"

### スラッシュなし ###
echo "Tokyo Osaka" | ./distance
[ "$?" = 1 ] || ng "$LINENO"

# 最終評価
[ "${res}" = 0 ] && echo OK

exit $res
