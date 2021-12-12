# Algoritma ve Veri Yapilari İlk Ödev



## [22,27,16,2,18,6] -> Insertion Sort
* Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
```
[22,27,16,2,18,6] (n)
[2,27,16,22,18,6] (n-1)
[2,6,16,22,18,27] (n-2)
[2,6,16,18,22,27] (1)
```
* Big-O gösterimini yazınız.

```
n + (n-1) + (n-2) + 1 {1'den n'e kadar olan sayiların toplamı formulü olan (n*(n+1))/2'den} 
(n^2 + n) / 2 
= O(n^2)
```
* Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
```
Average case:
[2,6,16,18,22,27] - > 16,18

Worst case:
[2,6,16,18,22,27] - > 27

Best case:
[2,6,16,18,22,27] - > 2

```
* Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.
```
Average case kapsamında.
```
* [7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.
```
[7,3,5,8,2,9,4,15,6] n
[2,3,5,8,7,9,4,15,6] (n-1)
[2,3,4,8,7,9,5,15,6] (n-2)
[2,3,4,5,7,9,8,15,6] (n-3)
```



