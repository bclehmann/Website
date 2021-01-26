"""this script renames all readme.md files to index.md"""

import os
import glob

for fname in glob.glob("*/readme.md"):
    fname2 = os.path.dirname(fname)+"/index.md"
    os.rename(fname, fname2)
    print(fname2)
