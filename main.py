import os
import codecs

def generate_tree_structure(root_dir):
    tree = ""
    for root, _, files in os.walk(root_dir):
        level = root.replace(root_dir, '').count(os.sep)
        indent = "|   " * (level - 1) + "|-- "
        tree += f"{indent}{os.path.basename(root)}/\n"

        for filename in files:
            file_path = os.path.join(root, filename)
            indent = "|   " * level
            tree += f"{indent}{filename}\n"
            # if filename.endswith(".cs"):
            #     with codecs.open(file_path, "r", encoding="utf-8", errors="ignore") as file:
            #         content = file.read()
            #         tree += content

    return tree

# Provide the root directory of your MonoGame project
root_directory = r"C:\\Users\\avikj\\source\\repos\\DevQuickie\\Project002-TopDownShooter"

# Generate the tree structure
tree_structure = generate_tree_structure(root_directory)

# Save the tree structure to a file
with codecs.open("tree.txt", "w", encoding="utf-8", errors="ignore") as file:
    file.write(tree_structure)

print("Tree structure generated and saved to 'tree.txt'")
