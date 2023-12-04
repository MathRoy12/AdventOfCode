f = open("input.txt")

x = []
copieParCarte = []

for y in f.readlines():
    x.append(y.removesuffix("\n").split(': '))
    copieParCarte.append(1)

sum = 0
for i in range(0,x.__len__()):
    for j in range(0,copieParCarte[i]):
        nbGagnant = 0
        x[i][0] = x[i][0].removeprefix("Card ")
        listWin = []
        for z in x[i][1].split("|")[0].split(" "):
            if(z != ''):
                listWin.append(z)
        listNum = []
        for z in x[i][1].split("|")[1].split(" "):
            if(listWin.__contains__(z)):
                nbGagnant+= 1
        for k in range(0,nbGagnant):
            copieParCarte[int(x[i][0]) + k] += 1

for y in copieParCarte:
    sum += y

print(sum)
f.close()