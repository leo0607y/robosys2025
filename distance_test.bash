#!/bin/bash -xv
#SPDX-FileCopyrightText: 2025 Reo Yamaguchi reo.yamaguchi0607@gmail.com
#SPDX-License-Identifier: BSD-3-Clause

ng (){
	echo "❌ ${1}行目でテストが失敗しました"
	res=1
}

res=0

#正常
out=$(printf "Tokyo\nNY\n" | ./distance)

[ "$?" = 0 ] || ng "$LINENO"
[ "$(echo "${out}" | grep -c "km")" = 1 ] || ng "$LINENO"
[ "$(echo "${out}" | grep -c "mile")" = 1 ] || ng "$LINENO"

#エラー　実在しない
Error_city="takiase"
out=$(printf "Tokyo\n%s\n" "${Error_city}" | ./distance)

[ "$?" = 1 ] || ng "$LINENO"
[ "$(echo "${out}" | grep -E -c "Not found ${Error_city}|Error")" = 1 ] || ng "$LINENO"

#エラー　入力無し
Nothingness_city=""
out=$(printf "%s\nurayasu\n" "${Nothingness_city}" | ./distance)

[ "$?" = 1 ] || ng "$LINENO"
[ "$(echo "${out}" | grep -E -c "Not found ${Nothingness_city}|Error")" = 1 ] || ng "$LINENO"

#最終評価
[ "${res}" = 0 ] && echo OK

exit $res
