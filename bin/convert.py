def convert(fromx, val):
	if fromx == "E":
		return val*1000000000000000000

	elif fromx == "P":
		return val*1000000000000000
		
	elif fromx == "T":
		return  val*1000000000000

	elif fromx == "G":
		return  val*1000000000

	elif fromx == "M":
		return  val*1000000

	elif fromx == "k":
		return  val*1000

	elif fromx == "g":
		return  val*100

	elif fromx == "da":
		return  val*10

	elif fromx == "d":
		return val/10

	elif fromx == "c":
		return val/100

	elif fromx == "m":
		return val/1000

	elif fromx == "mk":
		return val/1000000

	elif fromx == "n":
		return val/1000000000

	elif fromx == "p":
		return val/1000000000000000

	elif fromx == "a":
		return val/1000000000000000000
def length(fromx, to, length):

	#mm###############################

	if fromx == "mm" and to == "mm":
		return length

	elif fromx == "mm" and to == "cm":
		return length/10

	elif fromx == "mm" and to == "dm":
		return length/100

	elif fromx == "mm" and to == "m":
		return length/1000

	elif fromx == "mm" and to == "km":
		return length/1000000

	#cm###############################

	elif fromx == "cm" and to == "mm":
		return length*10

	elif fromx == "cm" and to == "cm":
		return length

	elif fromx == "cm" and to == "dm":
		return length/10

	elif fromx == "cm" and to == "m":
		return length/100

	elif fromx == "cm" and to == "km":
		return length/100000

	#dm################################

	elif fromx == "dm" and to == "mm":
		return length*100

	elif fromx == "dm" and to == "cm":
		return length*10

	elif fromx == "dm" and to == "dm":
		return length

	elif fromx == "dm" and to == "m":
		return length/10

	elif fromx == "dm" and to == "km":
		return length/10000

	#m################################

	elif fromx == "m" and to == "mm":
		return length*1000

	elif fromx == "m" and to == "cm":
		return length*100

	elif fromx == "m" and to == "dm":
		return length*10

	elif fromx == "m" and to == "m":
		return length

	elif fromx == "m" and to == "km":
		return length/1000

	#km###############################

	elif fromx == "km" and to == "mm":
		return length*1000000

	elif fromx == "km" and to == "cm":
		return length*100000

	elif fromx == "km" and to == "dm":
		return length*10000

	elif fromx == "km" and to == "m":
		return length*1000

	elif fromx == "km" and to == "km":
		return length

def area(fromx, to, length):

	#mm2##############################

	if fromx == "mm2":
			
		if to == "mm2":
			return length

		elif to == "cm2":
			return length/100

		elif to == "dm2":
			return length/10000

		elif to == "m2":
			return length/1000000

		elif to == "km2":
			return length/1000000000000

	#cm2##############################

	elif fromx == "cm2":

		if to == "mm2":
			return length*100

		elif to == "cm2":
			return length

		elif to == "dm2":
			return length/100

		elif to == "m2":
			return length/10000

		elif to == "km2":
			return length/10000000000

	#dm2##############################

	elif fromx == "dm2":

		if to == "mm2":
			return length*10000

		elif to == "cm2":
			return length*100

		elif to == "dm2":
			return length

		elif to == "m2":
			return length/100

		elif to == "km2":
			return length/100000000

	#m2###############################

	elif fromx == "m2":

		if to == "mm2":
			return length*1000000

		elif to == "cm2":
			return length*10000

		elif to == "dm2":
			return length*100

		elif to == "m2":
			return length

		elif to == "km2":
			return length/1000000

	#km2##############################

	elif fromx == "km2":

		if to == "mm2":
			return length*1000000000000

		elif to == "cm2":
			return length*10000000000

		elif to == "dm2":
			return length*100000000

		elif to == "m2":
			return length*1000000

		elif to == "km2":
			return length

def volume(fromx, to, length):

	#mm3###############################

	if fromx == "mm3":

		if  to == "mm3":
			return length

		elif to == "cm3":
			return length/1000

		elif to == "dm3":
			return length/1000000

		elif to == "m3":
			return length/1000000000

		elif to == "km3":
			return length/1000000000000000000

	#cm3###############################

	elif fromx == "cm3":

		if  to == "mm3":
			return length*1000

		elif to == "cm3":
			return length

		elif to == "dm3":
			return length/1000

		elif to == "m3":
			return length/1000000

		elif to == "km3":
			return length/1000000000000000

	#dm3###############################

	elif fromx == "dm3":

		if  to == "mm3":
			return length*1000000

		elif to == "cm3":
			return length*1000

		elif to == "dm3":
			return length

		elif to == "m3":
			return length/1000

		elif to == "km3":
			return length/1000000000000

	#m3################################

	elif fromx == "m3":

		if  to == "mm3":
			return length*1000000000

		elif to == "cm3":
			return length*1000000

		elif to == "dm3":
			return length*1000

		elif to == "m3":
			return length

		elif to == "km3":
			return length/1000000000

	#km3###############################

	elif fromx == "km3":

		if  to == "mm3":
			return length*1000000000000000000

		elif to == "cm3":
			return length*1000000000000000

		elif to == "dm3":
			return length*1000000000000

		elif to == "m3":
			return length*1000000000

		elif to == "km3":
			return length

	else:
		return -1