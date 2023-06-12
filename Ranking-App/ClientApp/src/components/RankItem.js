import React, { useState, useEffect } from 'react';
import MovieImageArra from './MovieImages';
import RankingGrid from './RankingGrid';

const RankItem = () => {
    const [items, setItems] = useState([]);
    const dataType = 1;
    useEffect(() => {
        fetch( 'item/'+  dataType)
            .then((results) => {
                if (!results.ok) {
                    throw new Error('Failed to fetch items');
                }
                return results.json();
            })

            .then(data => { setItems(data); })
            .catch((error) => {
                console.error(error);
            })
    }, [])
    return ( 
        <main>
            <RankingGrid items={items} imgArr={MovieImageArra} />
            <div className='items-not-rank'>
                {(items.length > 0) ?
                    items.map((item) => <div className='unranked-cell' key={item.id }> 
                        <img
                            id={'item-' + item.id}
                            src={MovieImageArra.find((o) => o.id === item.imageId)?.image}
                        />
                    
                </div> ): <div>Loading.....</div>
                }
            </div>
        </main>

    )
}
export default RankItem;