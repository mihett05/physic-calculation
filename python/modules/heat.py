class heat:

	def capacity(self, jl, mass, temp):
		return jl/mass*temp

	def amount(self, capacity, mass, t1, t2):
		return capacity*mass*(t2-t1)

	def combustion(self, amount, mass):
		return amount*mass

	def melting(self, h, mass):
		return  h*mass

	def steam(self, l, mass):
		return l*mass

	