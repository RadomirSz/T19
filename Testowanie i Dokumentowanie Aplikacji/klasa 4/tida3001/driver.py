import time
from selenium import webdriver

driver = webdriver.Chrome()
time.sleep(3)

driver.get("https://www.saucedemo.com/")

driver.find_element(by: "id", value: "user-name")
user.send_keys("standard_user")

password = driver.find_element(by: "id", value: "password")
password.send_keys("secret_sauce")


button = driver.find_element(by: "id", value: "login-button")
button.click()


time.sleep(10)
driver.quit()