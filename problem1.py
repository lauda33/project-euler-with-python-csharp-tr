"""
Project Euler Problem 1 

EN:If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.

TUR:Eğer 10'un altındaki 3 veya 5'in katı doğal sayıları listelersek 3,5,6 ve 9 elde ederiz.
Bu katların toplamı 23.
1000'den küçük 3'ün veya 5'in katlarının toplamını bulun
"""

# List comprehension ile 0 dan 1000'e kadar sayıları döndük
# Eğer sayı 3'e veya 5'e bölünüyorsa listemize ekledik ve toplamını hesapladık
print(sum([i for i in range(0,1000) if i%3==0 or i%5==0 ]))