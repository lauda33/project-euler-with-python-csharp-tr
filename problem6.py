"""
Project Euler Problem 6

EN:The sum of the squares of the first ten natural numbers is 385,
The square of the sum of the first ten natural numbers is 3025 ,
Hence the difference between the sum of the squares of the first ten natural numbers 
and the square of the sum is 2640 .
Find the difference between the sum of the squares of the first one hundred
 natural numbers and the square of the sum.
 
TUR: İlk 10 doğal sayının karelerinin toplamı 385'tir.
İlk 10 doğal sayının toplamının karesi ise 3025'tir.
Bu nedenle ilk 10 doğal sayının toplamının karesi ile ilk 10 doğal sayının karesinin toplamının 
arasındaki fark 2640'tır.

İlk yüz doğal sayının karelerinin toplamı ile ilk yüz sayının toplamının karesinin arasındaki
farkı bulun.
"""

first_100_square_sum = sum([i**2 for i in range(1,101)])
first_100_sum_square = (sum([i for i in range(1,101)]) ** 2)

print(abs(first_100_sum_square-first_100_square_sum))

