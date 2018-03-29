class force:

	g = 9.8

	def __init__(self):
		pass

	def gravity(self, mass):
		return mass*self.g

	def friction(self, mass, mu):
		return mu*mass*self.g

	def elasticity(self, k, l):
		return k*l

	def weight(self, mass):
		return mass*self.g

	def archimedes(self, density_liquid, volume):
		return density_liquid*self.g*volume
