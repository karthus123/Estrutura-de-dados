public class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    // metodo para calcular a altura do nó na árvore
    public int GetHeight()
    {
        int height = 1;
        TreeNode<T> current = this;
        while (current.Parent != null)
        {
            height++;
            current = current.Parent;
        }
        return height;
    }
}

public class Tree<T>
{
    public TreeNode<T> Root { get; set; }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

    // construtor padrão
    public Person() { }

    // construtor com parâmetros
    public Person(int id, string name, string role)
    {
        Id = id;
        Name = name;
        Role = role;
    }
}

public class Program
{
    static void Main()
    {
        Tree<Person> companyTree = new Tree<Person>();

        // criando a árvore organizacional da empresa
        companyTree.Root = new TreeNode<Person>()
        {
            Data = new Person(100, "Marcin Jamro", "CEO"),
            Parent = null
        };

        companyTree.Root.Children = new List<TreeNode<Person>>()
        {
            new TreeNode<Person>()
            {
                Data = new Person(1, "John Smith", "Head of Development"),
                Parent = companyTree.Root
            },
            new TreeNode<Person>()
            {
                Data = new Person(50, "Maty Fox", "Head of Research"),
                Parent = companyTree.Root
            },
            new TreeNode<Person>()
            {
                Data = new Person(150, "Lily Smith", "Head of Sales"),
                Parent = companyTree.Root
            }
        };

        companyTree.Root.Children[2].Children = new List<TreeNode<Person>>()
        {
            new TreeNode<Person>()
            {
                Data = new Person(30, "Anthony Black", "Sales Specialist"),
                Parent = companyTree.Root.Children[2]
            }
        };

        // exemplos de consultas a arvore organizacional
        Console.WriteLine($"A ID do líder do setor de vendas é {companyTree.Root.Children[2].Data.Id}.");
        Console.WriteLine($"O nome do especialista do setor de vendas é {companyTree.Root.Children[2].Children[0].Data.Name}.");
    }
}
