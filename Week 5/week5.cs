    public Text goldText;
    public Text crystalText;
    public Text foodText;
    public Text woodText;
    public Text ironText;

    void UpdateResource(Text textElement, int amount)
    {
        textElement.text = "Amount: " + amount.ToString();
    }