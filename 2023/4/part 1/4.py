f = open("input.txt")

x = []

for y in f.readlines():
    x.append(y.split(': ')[1].removesuffix("\n"))

sum = 0
for y in x:
    cpt = 0
    listWin = []
    for z in y.split("|")[0].split(" "):
        if(z != ''):
            listWin.append(z)
    listNum = []
    for z in y.split("|")[1].split(" "):
        if(listWin.__contains__(z)):
            cpt+= 1
    if(cpt > 0):
        sum += pow(2,cpt - 1)

print(sum)
f.close()