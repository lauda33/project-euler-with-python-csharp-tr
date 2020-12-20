import random
import math

while True:
    a = random.randint(1,1000)
    b = random.randint(1,1000)
    
    c = math.sqrt(a**2+b**2)
    
    if a+b+c == 1000:
        break
    

print("{},{},{}".format(a,b,c))
print(a*b*c)
