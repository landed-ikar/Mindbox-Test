        (SELECT product_name, category_name
           FROM products AS p
LEFT OUTER JOIN product_category AS pc
             ON p.product_id = pc.product_id
LEFT OUTER JOIN categories AS c 
             ON c.category_id = pc.category_id)
          UNION
        (SELECT NULL, category_Name
           FROM categories AS c
LEFT OUTER JOIN product_category AS pc
             ON c.category_id = pc.category_id
          WHERE pc.product_id IS NULL)
