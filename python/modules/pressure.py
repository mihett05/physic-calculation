class pressure:
	def __init__(self):
		pass

	def pressure(self, force, area):
		return force/area

	def liquid(self, density, h):
		return density*9.8*h
		