class Order {
  private $items = array();
  private $total = 0;
  private $taxRate = 0.10;
  
  public function addItem($item, $price) {
    $this->items[] = array('item' => $item, 'price' => $price);
    $this->total += $price;
  }
  
  public function getTax() {
    return $this->total * $this->taxRate;
  }
  
  public function getTotal() {
    return $this->total + $this->getTax();
  }
  
  public function save() {
    $db = new Database();
    $db->saveOrder($this->items, $this->getTotal());
  }
}
