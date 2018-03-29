class speed:

	def __init__(self):
		pass

	def speed(self, time, distance):
		return distance/time

	def time(self, speed, distance):
		return distance/speed

	def distance(self, speed, time):
		return speed*time
		