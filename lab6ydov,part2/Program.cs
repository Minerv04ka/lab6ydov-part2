import matplotlib.pyplot as plt
import numpy as np

# Табличні дані
x_data = np.array([-0.5, -0.3, -0.2, 0.1, 0.4, 0.8])
y_data = np.array([2.3, 1.2, 1.05, 0.9, 1.2, 2.1])

# Побудова графіку точок
plt.scatter(x_data, y_data, label='Табличні дані')
plt.xlabel('x')
plt.ylabel('y')
plt.legend()
plt.title('Точки таблиці на координатній площині')

# Показати графік
plt.show()
