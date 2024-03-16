# sha md5
from hashlib import md5

print(md5(b"Gruszka1").hexdigest())
print(md5(b"Gruszka2").hexdigest())
print(md5(b"G").hexdigest())

passw = "sawardega"
print(md5(passw.encode("iso-8859-1")).hexdigest())



