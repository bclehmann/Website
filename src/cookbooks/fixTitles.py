"""This script fixes old style <!-- titles --> to new style with frontmatter"""

import os
import glob

for fname in glob.glob("*/index.md"):
    with open(fname) as f:
        lines = f.readlines()
    if lines[0].startswith("---"):
        continue
    version = os.path.dirname(fname)
    frontmatter = "---\n" +\
        "Title: ScottPlot %s Cookbook\n" % version +\
        "---\n"
    lines[0] = frontmatter + lines[0]
    with open(fname, 'w') as f:
        f.writelines(lines)
    print("wrote", fname)
