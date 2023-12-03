f = open("input.txt", "r")
x = f.read().split("\n")
result = 0
cpt = 0
for y in x:
    try:
        cpt += int(y)
    except:
        if(cpt > result):
            result = cpt
        cpt = 0
    print(cpt)

print(result)
f.close()