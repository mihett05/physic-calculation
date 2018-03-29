import sys
import math
from os import name, system
path = "_"
if name == "nt":
	path = "\\modules"
elif name == "posix" or "mac":
	path = "/modules"
sys.path.append(sys.path[0]+path)

import settings as sett

from speed      import *
from force      import *
from pressure   import *
from density    import *
from mechanical import *
from energy     import *
from convert    import *
from heat       import *
from humidity   import *
from amperage   import *


def round(numObj, point=sett.point):
    return f"{numObj:.{point}f}"

speed      = speed()
force      = force()
pressure   = pressure()
density    = density()
mechanical = mechanical()
energy     = energy()
convert    = convert()
heat       = heat()
humidity   = humidity()
