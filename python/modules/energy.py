class energy:
	def __init__(self):
		pass

	def potential(self, mass, height):
		return mass*9.8*height

	def kinetic(self, mass, speed):
		return (mass*(speed*2))/2
		
	def save(kinetic, potential):
		return kinetic+potential

	def voltage(self, a, q):
		return a/q