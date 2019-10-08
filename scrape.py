import requests
import re
from bs4 import BeautifulSoup
with open('cric.html') as html_file:
    soup = BeautifulSoup(html_file,'lxml')
text = soup.find('div',{'class' : 'divleft'})
text.append(soup.find('div',{'class' : 'divright'}))
child = text.findAll('h2')
#child.append(text[1].findAll('h2'))
#.append(text[1].findAll('he')
count = 0
for item in child:
    item = item.text
    print(item)
linksList = []
li = text.findAll('li')
for a in li:
    linksList.append(a.find('a').text)
    linksList.append("https://www.espncricinfo.com"+(a.find('a').get('href')))
for stuff in linksList:
    print(stuff)


