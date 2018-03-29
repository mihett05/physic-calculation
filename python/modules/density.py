class density:
	def __init__(self):
		pass
	
	def density(self, mass, volume):
		return mass/volume

	def mass(self, density, volume):
		return density*volume

	def volume(self, density, mass):
		return mass/density
		