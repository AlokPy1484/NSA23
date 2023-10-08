from  selenium.webdriver.common.keys import Keys
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import time
from bs4 import BeautifulSoup




PATH = "C:\Program Files (x86)\chromedriver.exe"
driver = webdriver.Chrome()
    

driver.get("https://exoplanets.nasa.gov/discovery/exoplanet-catalog/")
print(driver.title)

f = open("Nasa_data2.csv","w")




#data scraper--------------------------------------------------------
while (True):
    wait = int(input("Next Page"))

    if wait == 0:
        f.close()
        break

    exo = driver.find_elements(By.CLASS_NAME, 'exoplanet')
    print(len(exo))

    for i in range(len(exo)):
        nasa = [0,0,0,0,0]

        data = exo[i].get_attribute('innerHTML')
        crap = BeautifulSoup(data, "html.parser")
        #Name
        exo_name = crap.find('a').text
        #distance
        exo_dis = crap.find(class_='st_dist').text
        #mass
        exo_mass = crap.find(class_='mass_display').text
        #mag
        exo_mag = crap.find(class_='st_optmag').text
        #discov_year
        exo_yea = crap.find(class_='discovery_date').text

        nasa[0] = exo_name
        nasa[1] = exo_dis
        nasa[2] = exo_mass
        nasa[3] = exo_mag
        nasa[4] = exo_yea

        #print(exo_name,",",exo_dis,",",exo_mass,",",exo_mag,",",exo_yea)
        print(nasa)
        print('\n')

        for i in range(len(nasa)):
            f.write(nasa[i])
            f.write(",")


        f.write("\n")






