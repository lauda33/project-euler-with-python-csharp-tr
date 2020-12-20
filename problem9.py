"""
Project Euler Problem 9

EN:A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

TUR: Bir pisagor üçgeni 3 doğal sayı içeren (a<b<c olacak şekilde akare+bkare = ckare kuralının karşılayan) bir kümedir.

a+b+c = 1000 kuralını karşılayan sadece bir üçgen vardır, üçgenin kenarları çarpımını bulun.

"""

import random
import math

while True:
    # Rastgele bir şekilde a ve b değerlerini çekiyoruz
    a = random.randint(1,1000)
    b = random.randint(1,1000)
    
    # a ve b'nin karelerinin toplamı c kare olduğuna göre bu değerin karesi c ye eşittir
    c = math.sqrt(a**2+b**2)
    
    # eğer a+b+c 1000'e eşitse sonsuz döngüyü kırıyoruz
    if a+b+c == 1000:
        break
    
# Değerleri ekrana yazdırıyoruz
print("{},{},{}".format(a,b,c))
print(a*b*c)
