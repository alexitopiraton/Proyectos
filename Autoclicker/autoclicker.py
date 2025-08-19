import pyautogui
import time

# "Botón de emergencia". Si se mueve el cursor a una esquina de la pantalla, pyautogui automaticamente interrumpe el script con una excepción. 
# Por defecto ya está en True, pero por si acaso.
pyautogui.FAILSAFE = True

# Espera 5 segundos antes de empezar (para que tengas tiempo de abrir lo que quieras)
time.sleep(5)

# Retorna ancho y alto de la pantalla
width, height = pyautogui.size()

# Calculamos el centro de la pantalla
x = width // 2
y = height // 2

# Movemos el cursor donde queramos (con x,y), en este caso al centro de la pantalla
pyautogui.moveTo(x, y)

# Hace clics infinitos
while True:
    pyautogui.tripleClick()