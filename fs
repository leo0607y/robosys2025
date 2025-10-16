[1mdiff --git a/lesson1~3/ans b/lesson1~3/ans[m
[1mdeleted file mode 100644[m
[1mindex 2ab5096..0000000[m
[1m--- a/lesson1~3/ans[m
[1m+++ /dev/null[m
[36m@@ -1 +0,0 @@[m
[31m-55.0[m
[1mdiff --git a/lesson1~3/args b/lesson1~3/args[m
[1mdeleted file mode 100755[m
[1mindex 299ffe9..0000000[m
[1m--- a/lesson1~3/args[m
[1m+++ /dev/null[m
[36m@@ -1,3 +0,0 @@[m
[31m-#!/usr/bin/python3[m
[31m-import sys  # sysモジュールを読み込み[m
[31m-print(sys.argv)[m
[1mdiff --git a/lesson1~3/fruits.py b/lesson1~3/fruits.py[m
[1mdeleted file mode 100644[m
[1mindex 015e670..0000000[m
[1m--- a/lesson1~3/fruits.py[m
[1m+++ /dev/null[m
[36m@@ -1,7 +0,0 @@[m
[31m-fruits = ["apple","banana","cherry"][m
[31m-[m
[31m-#for f in fruits:[m
[31m-#    print(f + "はおいしい")[m
[31m-print("最初の要素: " + fruits[0]) #先頭は0番目[m
[31m-print("次の要素: " + fruits[1]) #次の要素は1番目[m
[31m-print("最後の要素: " + fruits[-1]) #最後の要素[m
[1mdiff --git a/lesson1~3/hello b/lesson1~3/hello[m
[1mdeleted file mode 100755[m
[1mindex 990e3d5..0000000[m
[1m--- a/lesson1~3/hello[m
[1m+++ /dev/null[m
[36m@@ -1,4 +0,0 @@[m
[31m-#!/usr/bin/python3[m
[31m-[m
[31m-print("hello")[m
[31m-print(3.14)[m
[1mdiff --git a/lesson1~3/if_pra b/lesson1~3/if_pra[m
[1mdeleted file mode 100755[m
[1mindex b69362e..0000000[m
[1m--- a/lesson1~3/if_pra[m
[1m+++ /dev/null[m
[36m@@ -1,20 +0,0 @@[m
[31m-#!/usr/bin/python3[m
[31m-import sys[m
[31m-[m
[31m-minus, zero, plus = 0, 0, 0[m
[31m-[m
[31m-for n in sys.argv[1:]:[m
[31m-    x = float(n)[m
[31m-    if x < 0.0:[m
[31m-        #minus += 1[m
[31m-        print("負の値")[m
[31m-    elif x > 0.0:[m
[31m-        #plus += 1[m
[31m-        print("正の値")[m
[31m-    else:[m
[31m-        #zero += 1[m
[31m-        print("0")[m
[31m-[m
[31m-#print("minus:",minus)[m
[31m-#print("zero:",zero)[m
[31m-#print("plus:",plus)[m
[1mdiff --git a/lesson1~3/list.py b/lesson1~3/list.py[m
[1mdeleted file mode 100644[m
[1mindex 015e670..0000000[m
[1m--- a/lesson1~3/list.py[m
[1m+++ /dev/null[m
[36m@@ -1,7 +0,0 @@[m
[31m-fruits = ["apple","banana","cherry"][m
[31m-[m
[31m-#for f in fruits:[m
[31m-#    print(f + "はおいしい")[m
[31m-print("最初の要素: " + fruits[0]) #先頭は0番目[m
[31m-print("次の要素: " + fruits[1]) #次の要素は1番目[m
[31m-print("最後の要素: " + fruits[-1]) #最後の要素[m
[1mdiff --git a/lesson1~3/list2.py b/lesson1~3/list2.py[m
[1mdeleted file mode 100644[m
[1mindex f80b4c6..0000000[m
[1m--- a/lesson1~3/list2.py[m
[1m+++ /dev/null[m
[36m@@ -1,5 +0,0 @@[m
[31m-fruits = ["a", "b", "c", "d", "e" ][m
[31m-print("0番目から2番目の要素: ", fruits[0:3])[m
[31m-print("2番目以降の要素: ", fruits[2:])[m
[31m-print("ひとつ飛ばしでリストを作成: ", fruits[0::2])[m
[31m-[m
[1mdiff --git a/lesson1~3/list3.py b/lesson1~3/list3.py[m
[1mdeleted file mode 100644[m
[1mindex ed3dc06..0000000[m
[1m--- a/lesson1~3/list3.py[m
[1m+++ /dev/null[m
[36m@@ -1,3 +0,0 @@[m
[31m-raito = [1,2,3,4,5,6,7,8,9,10][m
[31m-print("奇数:",raito[0::2])[m
[31m-print("偶数:",raito[1::2])[m
[1mdiff --git a/lesson1~3/nums b/lesson1~3/nums[m
[1mdeleted file mode 100644[m
[1mindex f00c965..0000000[m
[1m--- a/lesson1~3/nums[m
[1m+++ /dev/null[m
[36m@@ -1,10 +0,0 @@[m
[31m-1[m
[31m-2[m
[31m-3[m
[31m-4[m
[31m-5[m
[31m-6[m
[31m-7[m
[31m-8[m
[31m-9[m
[31m-10[m
[1mdiff --git a/lesson1~3/plus_a b/lesson1~3/plus_a[m
[1mdeleted file mode 100755[m
[1mindex 399b9cd..0000000[m
[1m--- a/lesson1~3/plus_a[m
[1m+++ /dev/null[m
[36m@@ -1,4 +0,0 @@[m
[31m-#!/usr/bin/python3[m
[31m-import sys[m
[31m-print( float (sys.argv[1])+float (sys.argv[2]))[m
[31m-[m
[1mdiff --git a/lesson1~3/plus_b b/lesson1~3/plus_b[m
[1mdeleted file mode 100755[m
[1mindex 83c0230..0000000[m
[1m--- a/lesson1~3/plus_b[m
[1m+++ /dev/null[m
[36m@@ -1,8 +0,0 @@[m
[31m-#!/usr/bin/python3[m
[31m-import sys[m
[31m-[m
[31m-x = 0.0[m
[31m-for n in sys.argv[1:]:[m
[31m-	x += float(n)[m
[31m-print(x)[m
[31m-[m
[1mdiff --git a/lesson1~3/plus_c b/lesson1~3/plus_c[m
[1mdeleted file mode 100755[m
[1mindex f1c3aac..0000000[m
[1m--- a/lesson1~3/plus_c[m
[1m+++ /dev/null[m
[36m@@ -1,5 +0,0 @@[m
[31m-#!/usr/bin/python3[m
[31m-import sys[m
[31m-nums = [float(e) for e in sys.argv[1:]][m
[31m-print(sum(nums))[m
[31m-[m
[1mdiff --git a/lesson1~3/pra1.py b/lesson1~3/pra1.py[m
[1mdeleted file mode 100644[m
[1mindex c4da7d1..0000000[m
[1m--- a/lesson1~3/pra1.py[m
[1m+++ /dev/null[m
[36m@@ -1 +0,0 @@[m
[31m-import this[m
[1mdiff --git a/lesson1~3/read_stdin b/lesson1~3/read_stdin[m
[1mdeleted file mode 100755[m
[1mindex a4d529e..0000000[m
[1m--- a/lesson1~3/read_stdin[m
[1m+++ /dev/null[m
[36m@@ -1,7 +0,0 @@[m
[31m-#!/usr/bin/python3[m
[31m-[m
[31m-import sys[m
[31m-[m
[31m-for line in sys.stdin:[m
[31m-    word = line.strip() #最後に改行文字が入っているのでstripメソッドで除去[m
[31m-    print(word + " を標準入力から読んだよ")[m
[1mdiff --git a/lesson1~3/var.py b/lesson1~3/var.py[m
[1mdeleted file mode 100644[m
[1mindex 2a6b921..0000000[m
[1m--- a/lesson1~3/var.py[m
[1m+++ /dev/null[m
[36m@@ -1,3 +0,0 @@[m
[31m-name = "上田"[m
[31m-money = 5[m
[31m-print("{}の所持金：{}円".format(name,money))[m
