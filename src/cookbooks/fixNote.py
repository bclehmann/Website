"""This script replaces ![](cookbookNote.md) with a real message"""

import os
import glob

note = """
<div class="alert alert-secondary" role="alert">
  <strong>&#9888;&#65039; WARNING: This cookbook is specific to ScottPlot version {{VERSION}}.</strong>
  The API of different versions may vary, and newer versions of ScottPlot may be available. See the 
  <strong><a href="https://swharden.com/scottplot/cookbook">ScottPlot Cookbook Page</a></strong>
  for links to the latest versions of the cookbook.
</div>
"""

for fname in glob.glob("*/index.md"):
    version = os.path.dirname(fname)
    with open(fname) as f:
        lines = f.readlines()
    for i, line in enumerate(lines):
        if line.startswith("![](cookbookNote.md)"):
            lines[i] = note.replace("{{VERSION}}", version)
    with open(fname, 'w') as f:
        f.writelines(lines)
    print("wrote", fname)
