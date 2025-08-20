defmodule GildedRose do
  # Example
  # update_quality([%Item{name: "Backstage passes to a TAFKAL80ETC concert", sell_in: 9, quality: 1}])
  # => [%Item{name: "Backstage passes to a TAFKAL80ETC concert", sell_in: 8, quality: 3}]

  def update_quality(items) do
    Enum.map(items, &update_item/1)
  end

  @spec update_item(Item.t()) :: Item.t()
  def update_item(item = %Item{name: "Aged Brie"}) do
    item = cond do
      item.quality < 50 ->
        item = %{item | quality: item.quality + 1}
      true -> item
    end
    item = %{item | sell_in: item.sell_in - 1}
    cond do
      item.sell_in < 0 && item.quality < 50 ->
        %{item | quality: item.quality + 1}
      true -> item
    end
  end

  @spec update_item(Item.t()) :: Item.t()
  def update_item(item = %Item{name: "Backstage passes to a TAFKAL80ETC concert"}) do
    item = cond do
      item.quality < 50 ->
        item = %{item | quality: item.quality + 1}
        item = cond do
          item.sell_in < 11 && item.quality < 50 ->
                %{item | quality: item.quality + 1}
          true -> item
        end
        cond do
          item.sell_in < 6 && item.quality < 50 ->
            %{item | quality: item.quality + 1}
          true -> item
        end
      true -> item
    end
    item = %{item | sell_in: item.sell_in - 1}
    cond do
      item.sell_in < 0 ->
        %{item | quality: item.quality - item.quality}
      true -> item
    end
  end

  @spec update_item(Item.t()) :: Item.t()
  def update_item(item = %Item{name: "Sulfuras, Hand of Ragnaros"}) do
    item
  end

  @spec update_item(Item.t()) :: Item.t()
  def update_item(item) do
    item = if item.quality > 0 do
      %{item | quality: item.quality - 1}
    else
      item
    end
    item = %{item | sell_in: item.sell_in - 1}
    cond do
      item.sell_in < 0 && item.quality > 0 ->
        %{item | quality: item.quality - 1}
      true -> item
    end
  end
end
