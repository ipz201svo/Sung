import React from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import Card from 'react-bootstrap/Card';

interface Props {
  news: {
    id: string;
    title: string;
    authorId: string;
    author: string;
    publishingDate: string;
    imageUrl: string;
  },
  orientation: 'horizontal' | 'vertical',
}

function NewsCard({ news: { id, title, author, authorId, publishingDate, imageUrl }, orientation }: Props) {
  const image = (<Card.Img variant="bottom" src="https://images.unsplash.com/photo-1630329799541-e3e4db70b0bf?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1950&q=80" />);
  return (
    <>
      <Card bg="transparent" border="light">
        <Container>
          <Row>
            <Col>
              <Card.Body>
                <Card.Title>{title}</Card.Title>
                {/* <Card.Text>
                  {subtitle}
                </Card.Text> */}
                <Card.Text>
                  <small>by {author} / <span className="text-muted">{publishingDate}</span></small>
                </Card.Text>
              </Card.Body>
              {orientation === 'vertical' && image}
            </Col>
            {orientation === 'horizontal' && (<Col>{image}</Col>)}
          </Row>

        </Container>
      </Card>
    </>
  );
}

export default NewsCard;