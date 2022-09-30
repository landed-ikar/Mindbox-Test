        (select product_name, category_name
           from products as p
left outer join product_category as pc
             on p.product_id = pc.product_id
left outer join categories as c 
             on c.category_id = pc.category_id)
          union
        (select null, category_Name
           from categories as c
left outer join product_category as pc
             on c.category_id = pc.category_id
          Where pc.product_id is null)
