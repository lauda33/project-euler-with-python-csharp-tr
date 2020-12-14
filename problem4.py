"""
Project Euler Problem 4

EN:A palindromic number reads the same both ways. 
The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.

TUR: Palindrom bir sayı her yönden aynı şekilde okunur.
İki iki basamaklı sayının çarpılması sonucu oluşan en büyük palindrom sayı 9009'dur 

İki üç basamaklı sayının çarpılması sonucu oluşacak en büyük palindrom sayıyı bulun
"""

# Palindromları bu listede depolayacağız
largest_palindromes = []

# 100 den 1000'e bir for döngüsü döndürdük
for i in range(100,1001):
    
    # Bir tane daha
    for j in range(100,1001):
        
        # Bu sayıları çarptık ve string e dönüştürdük
        product = i * j
        
        product_str = str(product)
        
        control = True
        
        # Her karakterin indeksini döndürüyoruz
        for k in range(len(product_str)):
            
            # Burada matematiksel bir ifade var, aşağıda açıklayacağım
            if product_str[k] != product_str[(len(product_str)-1)-k]:
                control = False
                break
            
        
        if control:
            largest_palindromes.append(product)
            
print(max(largest_palindromes))

"""
Matematiksel Kısmın Açıklaması:

Palindromumuz 1325121 olsun

1. basamaktaki değer ile son basamaktaki değerin
2. basamaktaki değer ile son basamaktan bir önceki değerin
...

aynı olması gerekmektedir.

O zaman bir sayının palindrom olması için aşağıdaki formülü tüm basamaklarında karşılaması gerekir

basamak(n) == basamak(basamak_sayısı - n)

"""



            
            
            
            
        
            